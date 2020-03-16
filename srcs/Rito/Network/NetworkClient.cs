using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Rito.Core;
using Rito.Extensions;

namespace Rito.Network
{
    public sealed class NetworkClient : INetworkClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        
        public NetworkClient(string apiKey) : this()
        {
            _apiKey = apiKey;
        }
        
        public NetworkClient()
        {
            _httpClient = new HttpClient();
        }

        public Task<string> SendGetRequest(string url, Region region, params string[] parameters)
        {
            return SendGetRequest($"{region.GetPlatform()}{url}", parameters);
        }

        public async Task<string> SendGetRequest(string url, params string[] parameters)
        {
            using (HttpRequestMessage request = CreateHttpRequest(url, HttpMethod.Get, parameters))
            {
                HttpResponseMessage response = await SendRequest(request);
                using (HttpContent content = response.Content)
                {
                    return await content.ReadAsStringAsync();
                }
            }
        }

        public async Task<string> SendFormattedGetRequest(string url, params object[] parameters)
        {
            using (HttpRequestMessage request = CreateFormattedHttpRequest(url, HttpMethod.Get, parameters))
            {
                HttpResponseMessage response = await SendRequest(request);
                using (HttpContent content = response.Content)
                {
                    return await content.ReadAsStringAsync();
                }
            }
        }

        public Task<string> SendFormattedGetRequest(string url, Region region, params object[] parameters)
        {
            return SendFormattedGetRequest($"{region.GetPlatform()}{url}", parameters);
        }

        private async Task<HttpResponseMessage> SendRequest(HttpRequestMessage request)
        {
            HttpResponseMessage response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            return response;
        }

        private HttpRequestMessage CreateFormattedHttpRequest([NotNull] string url, HttpMethod method, [NotNull] params object[] parameters)
        {
            string formattedUrl = string.Format($"https://{url}", parameters);
            var request = new HttpRequestMessage(method, formattedUrl);
            if (!string.IsNullOrEmpty(_apiKey))
            {
                request.Headers.Add("X-Riot-Token", _apiKey);
            }

            return request;
        }
        
        [NotNull] 
        private HttpRequestMessage CreateHttpRequest([NotNull] string url, HttpMethod method, [CanBeNull] params string[] parameters)
        {
            var urlBuilder = new StringBuilder($"https://{url}");
            if (parameters != null)
            {
                urlBuilder.Append("?");
                foreach (string parameter in parameters)
                {
                    urlBuilder.Append(parameter).Append("&");
                }

                urlBuilder.Remove(urlBuilder.Length - 1, 1); // Remove last &
            }
            
            var request = new HttpRequestMessage(method, urlBuilder.ToString());
            if (!string.IsNullOrEmpty(_apiKey))
            {
                request.Headers.Add("X-Riot-Token", _apiKey);
            }

            return request;
        }
    }
}
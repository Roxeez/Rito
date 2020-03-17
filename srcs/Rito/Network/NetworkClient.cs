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

        public async Task<string> SendGetRequest(string url, params object[] parameters)
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

        public Task<string> SendGetRequest(Region region, string url, params object[] parameters)
        {
            return SendGetRequest($"{region.GetDomain()}{url}", parameters);
        }

        private async Task<HttpResponseMessage> SendRequest(HttpRequestMessage request)
        {
            HttpResponseMessage response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            return response;
        }

        private HttpRequestMessage CreateHttpRequest([NotNull] string url, HttpMethod method, [NotNull] params object[] parameters)
        {
            string formattedUrl = string.Format($"https://{url}", parameters);
            var request = new HttpRequestMessage(method, formattedUrl);
            if (!string.IsNullOrEmpty(_apiKey))
            {
                request.Headers.Add("X-Riot-Token", _apiKey);
            }

            return request;
        }
    }
}
using Newtonsoft.Json;

namespace Rito.Core.Serialization
{
    public class JsonDeserializer : IDeserializer
    {
        public T Deserialize<T>(string content) => JsonConvert.DeserializeObject<T>(content);
    }
}
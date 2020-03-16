namespace Rito.Core.Serialization
{
    public interface IDeserializer
    {
        T Deserialize<T>(string content);
    }
}
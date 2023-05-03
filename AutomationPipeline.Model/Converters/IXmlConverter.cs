namespace AutomationPipeline.Model.Converters
{
    public interface IXmlConverter
    {
        string Serializer<T>(T value);
        T Deserializer<T>(string xml);
    }
}

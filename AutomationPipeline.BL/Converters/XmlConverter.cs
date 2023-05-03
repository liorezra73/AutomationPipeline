using AutomationPipeline.Model.Converters;
using System.Runtime.Serialization;
using System.Xml;

namespace AutomationPipeline.BL.Converters
{
    public class XmlConverter : IXmlConverter
    {
        protected DataContractSerializer _serializer;
        public XmlConverter()
        {
            _serializer = new DataContractSerializer(typeof(object));
        }
        public T Deserializer<T>(string xml)
        {
            using (var stringReader = new StringReader(xml))
            {
                using (var xmlReader = XmlReader.Create(stringReader))
                {
                    var res = (T)_serializer.ReadObject(xmlReader);
                    return res;
                }
            }
        }

        public string Serializer<T>(T value)
        {
            MemoryStream stream = new MemoryStream();
            string serializedData;
            using (stream)
            {
                _serializer.WriteObject(stream, value);
                stream.Position = 0;
                StreamReader reader = new StreamReader(stream);
                serializedData = reader.ReadToEnd();
                Console.WriteLine(serializedData);
            }
            return serializedData;
        }
    }
}

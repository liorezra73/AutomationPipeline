using AutomationPipeline.BL.Commands;
using System.Runtime.Serialization;

namespace AutomationPipeline.BL.Converters
{
    public class XmlCommandFileConverter : XmlConverter
    {
        public XmlCommandFileConverter(List<Type> commandTypes) : base()
        {
            _serializer = new DataContractSerializer(typeof(CommandFile), commandTypes);
        }
    }
}

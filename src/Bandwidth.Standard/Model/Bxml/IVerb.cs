using System.Xml.Linq;

namespace bxml
{
    public interface IVerb
    {
        string Tag { get; set;}
        string Content { get; set;}
        Dictionary<string, string> Attributes { get; set;}
        XElement GenerateXml();
    }
}

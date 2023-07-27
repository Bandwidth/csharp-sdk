using System.Xml.Linq;

namespace Bandwidth.Standard.Model.Bxml
{
    public interface IVerb
    {
        string Tag { get; set;}
        string Content { get; set;}
        Dictionary<string, string> Attributes { get; set;}
        XElement GenerateXml();
    }
}

using System.Xml.Linq;

namespace bxml
{
    public class NestableVerb : IVerb
    {
        public string Tag { get; set; }
        public string Content { get; set; }
        public List<IVerb> NestedVerbs { get; set; }
        public Dictionary<string, string> Attributes { get; set; }

        public NestableVerb(){}

        public XElement GenerateXml()
        {

            var nestedVerbList = new List<XElement>();
            if(NestedVerbs != null)
            {
                foreach (var item in NestedVerbs)
                {
                    nestedVerbList.Add(item.GenerateXml());
                };
            }
            
            var verb = new XElement(this.Tag, nestedVerbList);
            if (Attributes != null)
            {
                foreach(var item in this.Attributes)
                {
                    verb.SetAttributeValue(item.Key, item.Value);
                }
            }
            return verb;
        }
    }
}

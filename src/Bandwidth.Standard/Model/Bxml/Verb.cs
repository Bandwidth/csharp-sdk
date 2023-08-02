using System.Xml.Linq;
namespace bxml
{
    public class Verb : IVerb
    {
        public string Tag { get; set; }
        public string Content { get; set; }
        public virtual Dictionary<string, string> Attributes { get; set; }

        public Verb(string Tag, string Content)
        {
            this.Tag = Tag;
            this.Content = Content;
            this.Attributes = new Dictionary<string, string> ();
        }

        public XElement GenerateXml()
        {
            var verb = new XElement(this.Tag, this.Content);
            if (this.Attributes != null)
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

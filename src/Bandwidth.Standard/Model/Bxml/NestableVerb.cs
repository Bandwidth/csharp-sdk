using System.Xml.Linq;

namespace Bandwidth.Standard.Model.Bxml
{
    public class NestableVerb : IVerb
    {

        public string Tag { get; set; }
        public string Content { get; set; }
        public List<IVerb> NestedVerbs { get; set; }
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Constructor for a Nestable Verb
        /// </summary>
        /// <param name="tag">Name of the XML element.</param>
        /// <param name="content">XML element text content.</param>
        /// <param name="nestedVerbs">XML element children.</param>
        /// <param name="attributes">The attributes to add to the element.</param>
        public NestableVerb(string tag, string content, List<IVerb> nestedVerbs, Dictionary<string,string> attributes)
        {
            Tag = tag;
            Content = content;
            NestedVerbs = nestedVerbs;
            Attributes = attributes;
        }
        
        /// <summary>
        /// Generate an XML element for the verb
        /// </summary>
        /// <returns>The XML element</returns>
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

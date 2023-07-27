using System.Xml.Linq;

namespace Bandwidth.Standard.Model.Bxml
{
    public class Verb : IVerb
    {

        public string Tag { get; set; }
        public string Content { get; set; }
        public Dictionary<string, string> Attributes { get; set; }


        /// <summary>
        /// Constructor for a Verb
        /// </summary>
        /// <param name="tag">Name of the XML element</param>
        /// <param name="content">XML element text content.</param>
        /// <param name="attributes">The attributes to add to the element.</param>
        public Verb(string tag, string content, Dictionary<string,string> attributes)
        {
            Tag = tag;
            Content = content;
            Attributes = attributes;
        }

        /// <summary>
        /// Generate an XML element for the verb
        /// </summary>
        /// <returns>The XML element</returns>
        public XElement GenerateXml()
        {
            var verb = new XElement(this.Tag, this.Content);
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


using System.Xml.Linq;
using Bandwidth.Standard.Model.Bxml;

namespace Bandwidth.Standard.Model.Bxml
{
    public class Root
    {
        public string Tag { get; set; }
        public List<IVerb> NestedVerbs = new List<IVerb>();

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="tag">Either "Bxml" or "Response"</param>
        public Root(string tag)
        {
            this.Tag = tag;
            this.NestedVerbs = new List<IVerb>();
        }

        /// <summary>
        /// Constructor for when nested verbs are provided
        /// </summary>
        /// <param name="tag">Either "Bxml" or "Response"</param>
        /// <param name="verbs">A list of nested verbs to be nested within the root element</param>
        public Root(string tag, List<IVerb> verbs)
        {
            this.Tag = tag;
            NestedVerbs.AddRange(verbs);
        }

        /// <summary>
        /// Returns BXML for response
        /// </summary>
        /// <returns>Generated XML string</returns>
        public string ToBxml()
        {
            XElement root = new XElement(Tag);
            foreach (var item in this.NestedVerbs)
            {
                XElement nestedVerb = item.GenerateXml();
                root.Add(nestedVerb);
            }
            return root.ToString();
        }
    }
}

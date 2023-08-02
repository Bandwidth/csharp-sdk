using System.Xml.Linq;
using bxml;

namespace bxml
{
    public class Root
    {
       public string Tag { get; set; }

       public List<IVerb> NestedVerbs = new List<IVerb>();

        public Root(string tag)
        {
            this.Tag = tag;
            this.NestedVerbs = new List<IVerb>();
        }

        public Root(string tag, List<IVerb> verbs)
        {
            this.Tag = tag;
            NestedVerbs.AddRange(verbs);
        }

        public void Add(IVerb verb)
        {
            Console.WriteLine("add Type: " + verb.GetType());
            NestedVerbs.Add(verb);
        }


        public string ToBXML()
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

namespace bxml
{
    /// <summary>
    ///   Bxml class for Bandwidth XML
    /// </summary>
    /// [XmlRoot(ElementName = "Bxml")]
    public class Bxml : Root
    {
        public Bxml() : base("Bxml"){}


        public Bxml(List<IVerb> verbs) : base("Bxml", verbs){}
        
    }
}

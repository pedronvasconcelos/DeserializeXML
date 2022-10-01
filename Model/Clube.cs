using System.Xml.Serialization;

namespace TestXML.Model
{
    public class Hobbies
    {
        [XmlElement("Principal")]
        public string Principal{ get; set; }
        [XmlElement("Secundario")]
        public string Secundario { get; set; }
    }
}

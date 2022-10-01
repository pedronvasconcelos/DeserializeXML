using System.Xml.Serialization;

namespace TestXML.Model
{
    public class Endereco
    {
        [XmlElement("Rua")]
        public string Rua { get; set; }
        [XmlElement("Cidade")]
        public string Cidade { get; set; }
    }
}

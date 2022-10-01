using System.Xml.Serialization;

namespace TestXML.Model
{
    [Serializable, XmlRoot("Pessoas")]
    public class Pessoas
    {
        [XmlElement("Pessoa")]
        public List<Pessoa> PessoaList { get; set; }
    }
}

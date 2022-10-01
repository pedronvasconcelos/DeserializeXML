using System.Xml.Serialization;

namespace TestXML.Model
{
    public class Pessoa
    {
        [XmlElement("Nome")]
        public string Nome { get; set; }
        [XmlElement("Idade")]
        public string Idade { get; set; }
        [XmlElement("Endereco")]
        public Endereco Endereco { get; set; }
        [XmlElement("Hobbies")]
        public Hobbies Hobbies { get; set; }
    }
}

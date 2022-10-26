using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TestXML.Model
{
    public class Pessoa
    {
        [DataMember(Name = "Nome")]
        public string Nome { get; set; }
        [DataMember(Name = "Idade")]
        public string Idade { get; set; }
        [DataMember(Name = "Endereco")]
        public Endereco Endereco { get; set; }
        [XmlElement("Hobbies")]
        public Hobbies Hobbies { get; set; }
    }
}

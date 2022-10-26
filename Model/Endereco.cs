using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TestXML.Model
{
    public class Endereco
    {
        [DataMember(Name = "Rua")]
        public string Rua { get; set; }
        [DataMember(Name = "Cidade")]
        public string Cidade { get; set; }
    }
}

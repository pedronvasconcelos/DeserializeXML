using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace TestXML.Model
{
    [DataContract(Name = "Pessoas", Namespace ="")]
    public class Pessoas
    {
        [DataMember(Name = "Pessoa")]              
        public List<Pessoa> Pessoa { get; set; }
    }
}

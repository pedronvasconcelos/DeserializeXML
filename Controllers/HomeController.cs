using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Json;
using TestXML.Helpers;
using TestXML.Model;

namespace TestXML.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IXmlHelper _xmlHelper;
        public HomeController(IXmlHelper xmlHelper)
        {
            _xmlHelper = xmlHelper; 
        }

        [HttpGet]
        public ActionResult Get()
        {
            string path = Directory.GetCurrentDirectory() + @"\File\convertjson.xml";

            string input = System.IO.File.ReadAllText(path);

            var customer = _xmlHelper.Deserialize<Pessoas>(input);
            return Ok(customer);
        }
    }
}
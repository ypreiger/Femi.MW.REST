using Femi.MW.REST.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web;
using System.Xml;

namespace Femi.MW.REST.Controllers
{
    [Route("api")]
    [ApiController]
    public class CarContactsController : Controller
    {
        [HttpGet]
        [Produces("application/json")]
        [Route("cars/contacts")]
        public IActionResult Get([FromQuery]string license)
        {
            string serviceName = "GetCarAssets";
            string inXmlString = $@"<?xml version=""1.0"" encoding=""UTF-16""?><FEMIGetContactCarAssetsIn><License>{license}</License></FEMIGetContactCarAssetsIn>";
            string inXml = HttpUtility.HtmlEncode(inXmlString);
            string soap = $@"<?xml version=""1.0"" encoding=""utf-8""?>
          <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:cus=""http://siebel.com/CustomUI"">
                <soapenv:Header/>
                <soapenv:Body>
                    <cus:_sblesc_spcRunWSDLInboundInt_Input>
                        <cus:MethodName></cus:MethodName>
                        <cus:ServiceName>{serviceName}</cus:ServiceName>
                        <cus:inXML>{inXml}</cus:inXML>
                    </cus:_sblesc_spcRunWSDLInboundInt_Input>
                </soapenv:Body>
           </soapenv:Envelope>";

            string xml = Soap.Execute(soap, "_sblesc_spcRunWSDLInboundInt");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string jsonText = JsonConvert.SerializeXmlNode(doc);
            return Ok(JObject.Parse(jsonText));

        }
    }
}
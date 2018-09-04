using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Femi.MW.REST.Helpers;
using Femi.MW.REST.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Femi.MW.REST.Controllers
{
    [Route("api")]
    [ApiController]
    public class HealthContactsController : ControllerBase
    {
        // GET
        [HttpGet]
        [Produces("application/json")]
        [Route("areas/{areaName}/contacts/{contactID}")]
        [ProducesResponseType(typeof(List<Contacts>), 200)]
        [ProducesResponseType(typeof(string), 400)]
        public IActionResult Get(string areaName, string contactID)
        {
            if (contactID.Length < 9) { return BadRequest(); }

            string soap = $@"<?xml version=""1.0"" encoding=""utf-8""?>
          <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:cus=""http://siebel.com/CustomUI"">
                <soapenv:Header/>
                <soapenv:Body>
                    <cus:GetContactAssets_Input>
                    <cus:SSN>{contactID}</cus:SSN>
                    <cus:Area>{areaName}</cus:Area>
                    </cus:GetContactAssets_Input>
                </soapenv:Body>
           </soapenv:Envelope>";

            string xml = Soap.Execute(soap, "GetContactAssets");
            int startIndex = xml.IndexOf("<Contact>");
            int endIndex = xml.IndexOf("</ListOfFemiContactIntIo>");
            xml = xml.Substring(startIndex, endIndex - startIndex);
            xml = "<Contacts>" + xml + "</Contacts>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlSerializer ser = new XmlSerializer(typeof(Contacts));
            Contacts contact;

            using (StringReader sr = new StringReader(xml))
            {
                contact = (Contacts)ser.Deserialize(sr);
            }
            
            string jsonText = JsonConvert.SerializeObject(contact);
            return Ok(JObject.Parse(jsonText));
        }
    }

}

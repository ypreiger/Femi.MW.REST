using Femi.MW.REST.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace Femi.MW.REST.Helpers
{
    public class Soap
    {
        /// <summary>
        /// Execute a Soap WebService call
        /// </summary>
        public static string Execute(string soapRequest, string action)
        {
            HttpWebRequest request = CreateWebRequest(action);
            XmlDocument soapEnvelopeXml = new XmlDocument();

            soapEnvelopeXml.LoadXml(soapRequest);

            using (Stream stream = request.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }

            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    string soapResult = rd.ReadToEnd();
                    return soapResult;
                }
            }
        }
        /// <summary>
        /// Create a soap webrequest to [Url]
        /// </summary>
        /// <returns></returns>
        public static HttpWebRequest CreateWebRequest(string action)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://sbleai-test.femi.com/eai_if_heb/start.swe?SWEExtCmd=Execute&SWEExtSource=SecureWebService&SWEExtCmd=Execute");
            string header = "SOAPAction:\"document/http://siebel.com/CustomUI:" + action + "\"";
            webRequest.Headers.Add(header);
            webRequest.ContentType = "text/xml;charset=utf-8";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }
    }
}

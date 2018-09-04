using System.Collections.Generic;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "Contacts")]
    public class Contacts
    {
        [XmlElement(ElementName = "Contact")]
        public List<Contact> Contact { get; set; }
    }
}

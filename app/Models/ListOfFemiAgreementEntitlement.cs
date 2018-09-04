using System.Collections.Generic;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "ListOfFemiAgreementEntitlement")]
    public class ListOfFemiAgreementEntitlement
    {
        [XmlElement(ElementName = "FemiAgreementEntitlement")]
        public List<FemiAgreementEntitlement> FemiAgreementEntitlement { get; set; }
    }
}

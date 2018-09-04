using System.Collections.Generic;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "ListOfFemiAgreementLineItemAsset")]
    public class ListOfFemiAgreementLineItemAsset
    {
        [XmlElement(ElementName = "FemiAgreementLineItemAsset")]
        public List<FemiAgreementLineItemAsset> FemiAgreementLineItemAsset { get; set; }
    }
}

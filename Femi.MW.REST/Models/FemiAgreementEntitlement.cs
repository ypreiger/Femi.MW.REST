using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "FemiAgreementEntitlement")]
    public class FemiAgreementEntitlement
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "Expose")]
        public string Expose { get; set; }
        [XmlElement(ElementName = "MaximumServices")]
        public string MaximumServices { get; set; }
        [XmlElement(ElementName = "Name4")]
        public string Name4 { get; set; }
        [XmlElement(ElementName = "QualificationDate2")]
        public string QualificationDate2 { get; set; }
        [XmlElement(ElementName = "SumServicesUsage")]
        public string SumServicesUsage { get; set; }
        [XmlElement(ElementName = "ListOfFemiAgreementLineItemAsset")]
        public ListOfFemiAgreementLineItemAsset ListOfFemiAgreementLineItemAsset { get; set; }
    }

}

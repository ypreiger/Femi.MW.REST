using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "FemiAsset-Rider")]
    public class FemiAssetRider
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "AccountName")]
        public string AccountName { get; set; }
        [XmlElement(ElementName = "OwnerAccountId")]
        public string OwnerAccountId { get; set; }
        [XmlElement(ElementName = "PolicySourceId")]
        public string PolicySourceId { get; set; }
        [XmlElement(ElementName = "PrimaryContactId2")]
        public string PrimaryContactId2 { get; set; }
        [XmlElement(ElementName = "ProductName")]
        public string ProductName { get; set; }
        [XmlElement(ElementName = "StartDate")]
        public string StartDate { get; set; }
        [XmlElement(ElementName = "ListOfFemiAgreementEntitlement")]
        public ListOfFemiAgreementEntitlement ListOfFemiAgreementEntitlement { get; set; }
    }

}

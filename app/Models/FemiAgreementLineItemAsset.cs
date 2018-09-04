using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "FemiAgreementLineItemAsset")]
    public class FemiAgreementLineItemAsset
    {
        [XmlElement(ElementName = "NumberOfServicesRemaining")]
        public string NumberOfServicesRemaining { get; set; }
        [XmlElement(ElementName = "ListOfFEMIFSAgreementSubItem")]
        public ListOfFEMIFSAgreementSubItem ListOfFEMIFSAgreementSubItem { get; set; }
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "ActivityCount")]
        public string ActivityCount { get; set; }
        [XmlElement(ElementName = "AgreementItemProductId")]
        public string AgreementItemProductId { get; set; }
        [XmlElement(ElementName = "AgreementItemProductName")]
        public string AgreementItemProductName { get; set; }
        [XmlElement(ElementName = "CurrentAvailableStock2")]
        public string CurrentAvailableStock2 { get; set; }
        [XmlElement(ElementName = "DeductionMax2")]
        public string DeductionMax2 { get; set; }
        [XmlElement(ElementName = "DeductionMax-Percent")]
        [JsonProperty(PropertyName = "DeductionMax-Percent")]
        public string DeductionMaxPercent { get; set; }
        [XmlElement(ElementName = "MaximumQuantity")]
        public string MaximumQuantity { get; set; }
        [XmlElement(ElementName = "ParentAgreementLineItemId")]
        public string ParentAgreementLineItemId { get; set; }
        [XmlElement(ElementName = "PeriodUOM2")]
        public string PeriodUOM2 { get; set; }
        [XmlElement(ElementName = "Write-InProduct")]
        [JsonProperty(PropertyName = "Write-InProduct")]
        public string WriteInProduct { get; set; }
    }

}

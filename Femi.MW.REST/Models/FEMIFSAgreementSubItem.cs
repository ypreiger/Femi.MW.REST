using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "FEMIFSAgreementSubItem")]
    public class FEMIFSAgreementSubItem
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "ParentAgreementItemId")]
        public string ParentAgreementItemId { get; set; }
        [XmlElement(ElementName = "ProductId")]
        public string ProductId { get; set; }
        [XmlElement(ElementName = "LineNumber")]
        public string LineNumber { get; set; }
        [XmlElement(ElementName = "Product")]
        public string Product { get; set; }
        [XmlElement(ElementName = "Write-InProduct")]
        [JsonProperty(PropertyName = "Write-InProduct")]
        public string WriteInProduct { get; set; }
        [XmlElement(ElementName = "LineNumber2")]
        public string LineNumber2 { get; set; }
    }

}

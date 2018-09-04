using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "Contact")]
    public class Contact
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "SelfServiceRegisteredFlag")]
        public string SelfServiceRegisteredFlag { get; set; }
        [XmlElement(ElementName = "BirthDate")]
        public string BirthDate { get; set; }
        [XmlElement(ElementName = "CellularPhone")]
        public string CellularPhone { get; set; }
        [XmlElement(ElementName = "ContactId")]
        public string ContactId { get; set; }
        [XmlElement(ElementName = "EmailAddress")]
        public string EmailAddress { get; set; }
        [XmlElement(ElementName = "FirstName")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "HomePhone")]
        public string HomePhone { get; set; }
        [XmlElement(ElementName = "IDExpirationDate")]
        public string IDExpirationDate { get; set; }
        [XmlElement(ElementName = "IDInformation")]
        public string IDInformation { get; set; }
        [XmlElement(ElementName = "LastName")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "PreferredCommunicationMethod")]
        public string PreferredCommunicationMethod { get; set; }
        [XmlElement(ElementName = "ListOfFemiAsset-Insurance")]
        [JsonProperty(PropertyName = "ListOfFemiAsset-Insurance")]
        public ListOfFemiAssetInsurance ListOfFemiAssetInsurance { get; set; }
    }

}

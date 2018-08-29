using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "FemiAsset-Insurance")]
    public class FemiAssetInsurance
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "ProductName")]
        public string ProductName { get; set; }
        [XmlElement(ElementName = "SerialNumber")]
        public string SerialNumber { get; set; }
        [XmlElement(ElementName = "ListOfFemiAsset-Rider")]
        public ListOfFemiAssetRider ListOfFemiAssetRider { get; set; }
    }
}

using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "ListOfFemiAsset-Insurance")]
    public class ListOfFemiAssetInsurance
    {
        [XmlElement(ElementName = "FemiAsset-Insurance")]
        [JsonProperty(PropertyName = "FemiAsset-Insurance")]
        public FemiAssetInsurance FemiAssetInsurance { get; set; }
    }
}

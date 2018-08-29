using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{
    [XmlRoot(ElementName = "ListOfFemiAsset-Rider")]
    public class ListOfFemiAssetRider
    {
        [XmlElement(ElementName = "FemiAsset-Rider")]
        [JsonProperty(PropertyName = "FemiAsset-Rider")]
        public FemiAssetRider FemiAssetRider { get; set; }
    }
}

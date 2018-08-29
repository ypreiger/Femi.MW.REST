using System.Collections.Generic;
using System.Xml.Serialization;

namespace Femi.MW.REST.Models
{

    [XmlRoot(ElementName = "ListOfFEMIFSAgreementSubItem")]
    public class ListOfFEMIFSAgreementSubItem
    {
        [XmlElement(ElementName = "FEMIFSAgreementSubItem")]
        public List<FEMIFSAgreementSubItem> FEMIFSAgreementSubItem { get; set; }
    }
}

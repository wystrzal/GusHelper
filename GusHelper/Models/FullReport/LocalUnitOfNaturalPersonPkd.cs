using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class LocalUnitOfNaturalPersonPkdRoot
    {
        [XmlElement("dane")]
        public LocalUnitOfNaturalPersonPkd Result { get; set; }
    }

    public class LocalUnitOfNaturalPersonPkd
    {
        [XmlElement("lokfiz_pkd_Kod")]
        public string Code { get; set; }

        [XmlElement("lokfiz_pkd_Nazwa")]
        public string Name { get; set; }

        [XmlElement("lokfiz_pkd_Przewazajace")]
        public string Overwhelming { get; set; }

        [XmlElement("lokfiz_Silos_Symbol")]
        public string SilosSymbol { get; set; }
    }
}

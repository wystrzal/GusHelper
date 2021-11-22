using System.Collections.Generic;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class LegalPersonPkdRoot
    {
        [XmlElement("dane")]
        public List<LegalPersonPkd> Results { get; set; }
    }

    public class LegalPersonPkd
    {
        [XmlElement("praw_pkdKod")]
        public string Code { get; set; }

        [XmlElement("praw_pkdNazwa")]
        public string Name { get; set; }

        [XmlElement("praw_pkdPrzewazajace")]
        public string Overwhelming { get; set; }
    }
}

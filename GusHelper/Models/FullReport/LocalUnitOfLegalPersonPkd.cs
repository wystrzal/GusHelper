using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class LocalUnitOfLegalPersonPkdRoot
    {
        [XmlElement("dane")]
        public LocalUnitOfLegalPersonPkd Result { get; set; }
    }


    public class LocalUnitOfLegalPersonPkd
    {
        [XmlElement("lokpraw_pkdKod")]
        public string Code { get; set; }

        [XmlElement("lokpraw_pkdNazwa")]
        public string Name { get; set; }

        [XmlElement("lokpraw_pkdPrzewazajace")]
        public string Overwhelming { get; set; }
    }
}

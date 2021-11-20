using GusHelper.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class NaturalPersonPkdRoot
    {
        [XmlElement("dane")]
        public NaturalPersonPkd Result { get; set; }
    }

    public class NaturalPersonPkd
    {
        [XmlElement("fiz_pkd_Kod")]
        public string Code { get; set; }

        [XmlElement("fiz_pkd_Nazwa")]
        public string Name { get; set; }

        [XmlElement("fiz_pkd_Przewazajace")]
        public string Overwhelming { get; set; }

        [XmlElement("fiz_SilosID")]
        public int SilosID { get; set; }

        [XmlElement("fiz_Silos_Symbol")]
        public string SilosSymbol { get; set; }

        [XmlElement("fiz_dataSkresleniaDzialalnosciZRegon")]
        public XmlDateTime DateOfDeletionFromRegon { get; set; }
    }
}

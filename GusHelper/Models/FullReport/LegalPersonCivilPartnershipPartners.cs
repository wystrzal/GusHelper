using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class LegalPersonCivilPartnershipPartnersRoot
    {
        [XmlElement("dane")]
        public LegalPersonCivilPartnershipPartners Result { get; set; }
    }

    public class LegalPersonCivilPartnershipPartners
    {
        [XmlElement("wspolsc_regonWspolnikSpolki")]
        public string Regon { get; set; }

        [XmlElement("wspolsc_imiePierwsze")]
        public string FirstName { get; set; }

        [XmlElement("wspolsc_imieDrugie")]
        public string SecondName { get; set; }

        [XmlElement("wspolsc_nazwisko")]
        public string LastName { get; set; }

        [XmlElement("wspolsc_firmaNazwa")]
        public string Name { get; set; }
    }
}

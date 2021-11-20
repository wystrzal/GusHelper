using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class NaturalPersonDeletedBusinessTo20141108Root
    {
        [XmlElement("dane")]
        public NaturalPersonDeletedBusinessTo20141108 Result { get; set; }
    }

    public class NaturalPersonDeletedBusinessTo20141108 : BaseNaturalPersonBusiness
    {
        [XmlElement("fiz_adresEmail2")]
        public string Email2 { get; set; }
    }
}

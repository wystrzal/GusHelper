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
    public class NaturalPersonAgriculturalBusinessRoot
    {
        [XmlElement("dane")]
        public NaturalPersonAgriculturalBusiness Result { get; set; }
    }

    public class NaturalPersonAgriculturalBusiness : BaseNaturalPersonBusiness
    {
        [XmlElement("fiz_dataOrzeczeniaOUpadlosci")]
        public XmlDateTime DateOfDeclarationBankruptcy { get; set; }

        [XmlElement("fiz_dataZakonczeniaPostepowaniaUpadlosciowego")]
        public XmlDateTime DateOfCompletionInsolvencyProceedings { get; set; }
    }
}

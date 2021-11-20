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
    public class NaturalPersonEconomicBusinessRoot
    {
        [XmlElement("dane")]
        public NaturalPersonEconomicBusiness Result { get; set; }
    }

    public class NaturalPersonEconomicBusiness : BaseNaturalPersonBusiness
    {
        [XmlElement("fiz_dataOrzeczeniaOUpadlosci")]
        public XmlDateTime DateOfDeclarationBankruptcy { get; set; }

        [XmlElement("fiz_dataZakonczeniaPostepowaniaUpadlosciowego")]
        public XmlDateTime DateOfCompletionInsolvencyProceedings { get; set; }

        [XmlElement("fizC_dataWpisuDoRejestruEwidencji")]
        public XmlDateTime DateOfEntryToRegisterOfRecords { get; set; }

        [XmlElement("fizC_dataSkresleniaZRejestruEwidencji")]
        public XmlDateTime DateOfRemovalFromRegisterOfRecords { get; set; }

        [XmlElement("fizC_numerWRejestrzeEwidencji")]
        public string NumberInRegisterOfRecords { get; set; }

        [XmlElement("fizC_OrganRejestrowy_Symbol")]
        public string RegistrationAuthoritySymbol { get; set; }

        [XmlElement("fizC_OrganRejestrowy_Nazwa")]
        public string RegistrationAuthority { get; set; }

        [XmlElement("fizC_RodzajRejestru_Symbol")]
        public string RegistryTypeSymbol { get; set; }

        [XmlElement("fizC_RodzajRejestru_Nazwa")]
        public string RegistryType { get; set; }

        [XmlElement("fizC_NiePodjetoDzialalnosci")]
        public bool NoBusinessTaken { get; set; }
    }
}

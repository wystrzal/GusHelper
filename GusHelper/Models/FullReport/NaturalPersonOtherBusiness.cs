using GusHelper.Utils;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class NaturalPersonOtherBusinessRoot
    {
        [XmlElement("dane")]
        public NaturalPersonOtherBusiness Result { get; set; }
    }

    public class NaturalPersonOtherBusiness : BaseNaturalPersonBusiness
    {
        [XmlElement("fiz_dataOrzeczeniaOUpadlosci")]
        public XmlDateTime DateOfDeclarationBankruptcy { get; set; }

        [XmlElement("fiz_dataZakonczeniaPostepowaniaUpadlosciowego")]
        public XmlDateTime DateOfCompletionInsolvencyProceedings { get; set; }

        [XmlElement("fizP_dataWpisuDoRejestruEwidencji")]
        public XmlDateTime DateOfEntryToRegisterOfRecords { get; set; }

        [XmlElement("fizP_numerWRejestrzeEwidencji")]
        public string NumberInRegisterOfRecords { get; set; }

        [XmlElement("fizP_OrganRejestrowy_Symbol")]
        public string RegistrationAuthoritySymbol { get; set; }

        [XmlElement("fizP_OrganRejestrowy_Nazwa")]
        public string RegistrationAuthority { get; set; }

        [XmlElement("fizP_RodzajRejestru_Symbol")]
        public string RegistryTypeSymbol { get; set; }

        [XmlElement("fizP_RodzajRejestru_Nazwa")]
        public string RegistryType { get; set; }
    }
}

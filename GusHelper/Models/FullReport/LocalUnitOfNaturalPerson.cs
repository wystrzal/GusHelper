using GusHelper.Utils;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class LocalUnitOfNaturalPersonRoot
    {
        [XmlElement("dane")]
        public LocalUnitOfNaturalPerson Result { get; set; }
    }

    public class LocalUnitOfNaturalPerson
    {
        [XmlElement("lokfiz_regon14")]
        public string Regon14 { get; set; }

        [XmlElement("lokfiz_nazwa")]
        public string Name { get; set; }

        [XmlElement("lokfiz_silosID")]
        public int SilosID { get; set; }

        [XmlElement("lokfiz_silos_Nazwa")]
        public string SilosName { get; set; }

        [XmlElement("lokfiz_dataPowstania")]
        public XmlDateTime DateOfCreation { get; set; }

        [XmlElement("lokfiz_dataRozpoczeciaDzialalnosci")]
        public XmlDateTime DateOfCommencementBusiness { get; set; }

        [XmlElement("lokfiz_dataWpisuDoRegon")]
        public XmlDateTime DateOfEntryToRegon { get; set; }

        [XmlElement("lokfiz_dataZawieszeniaDzialalnosci")]
        public XmlDateTime DateOfSuspensionBusiness { get; set; }

        [XmlElement("lokfiz_dataWznowieniaDzialalnosci")]
        public XmlDateTime DateOfResumptionBusiness { get; set; }

        [XmlElement("lokfiz_dataZaistnieniaZmiany")]
        public XmlDateTime DateOfChangeOccurrence { get; set; }

        [XmlElement("lokfiz_dataZakonczeniaDzialalnosci")]
        public XmlDateTime BusinessTerminationDate { get; set; }

        [XmlElement("lokfiz_dataSkresleniaZRegon")]
        public XmlDateTime DateOfDeletionFromRegon { get; set; }

        [XmlElement("lokfiz_adSiedzKraj_Symbol")]
        public string CountrySymbol { get; set; }

        [XmlElement("lokfiz_adSiedzWojewodztwo_Symbol")]
        public string ProvinceSymbol { get; set; }

        [XmlElement("lokfiz_adSiedzPowiat_Symbol")]
        public string CountySymbol { get; set; }

        [XmlElement("lokfiz_adSiedzGmina_Symbol")]
        public string CommuneSymbol { get; set; }

        [XmlElement("lokfiz_adSiedzKodPocztowy")]
        public string Postcode { get; set; }

        [XmlElement("lokfiz_adSiedzMiejscowoscPoczty_Symbol")]
        public string PostOfficeSymbol { get; set; }

        [XmlElement("lokfiz_adSiedzMiejscowosc_Symbol")]
        public string CitySymbol { get; set; }

        [XmlElement("lokfiz_adSiedzUlica_Symbol")]
        public string StreetSymbol { get; set; }

        [XmlElement("lokfiz_adSiedzNumerNieruchomosci")]
        public string PropertyNumber { get; set; }

        [XmlElement("lokfiz_adSiedzNumerLokalu")]
        public string ApartmentNumber { get; set; }

        [XmlElement("lokfiz_adSiedzNietypoweMiejsceLokalizacji")]
        public string UnusualLocation { get; set; }

        [XmlElement("lokfiz_adSiedzKraj_Nazwa")]
        public string Country { get; set; }

        [XmlElement("lokfiz_adSiedzWojewodztwo_Nazwa")]
        public string Province { get; set; }

        [XmlElement("lokfiz_adSiedzPowiat_Nazwa")]
        public string County { get; set; }

        [XmlElement("lokfiz_adSiedzGmina_Nazwa")]
        public string Commune { get; set; }

        [XmlElement("lokfiz_adSiedzMiejscowosc_Nazwa")]
        public string City { get; set; }

        [XmlElement("lokfiz_adSiedzMiejscowoscPoczty_Nazwa")]
        public string PostOffice { get; set; }

        [XmlElement("lokfiz_adSiedzUlica_Nazwa")]
        public string Street { get; set; }

        [XmlElement("lokfiz_FormaFinansowania_Nazwa")]
        public string FormOfFinancing { get; set; }

        [XmlElement("lokfiz_FormaFinansowania_Symbol")]
        public string FormOfFinancingSymbol { get; set; }

        [XmlElement("lokfiz_dataWpisuDoRejestruEwidencji")]
        public XmlDateTime DateOfEntryToRegisterOfRecords { get; set; }

        [XmlElement("lokfiz_numerwRejestrzeEwidencji")]
        public string NumberInRegisterOfRecords { get; set; }

        [XmlElement("lokfiz_OrganRejestrowy_Symbol")]
        public string RegistrationAuthoritySymbol { get; set; }

        [XmlElement("lokfiz_RodzajRejestru_Symbol")]
        public string RegistryTypeSymbol { get; set; }

        [XmlElement("lokfiz_OrganRejestrowy_Nazwa")]
        public string RegistrationAuthority { get; set; }

        [XmlElement("lokfiz_RodzajRejestru_Nazwa")]
        public string RegistryType { get; set; }

        [XmlElement("lokfizC_NiePodjetoDzialalnosci")]
        public bool NoBusinessTaken { get; set; }
    }
}

using GusHelper.Utils;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class LegalPersonRoot
    {
        [XmlElement("dane")]
        public LegalPerson Result { get; set; }
    }

    public class LegalPerson : BasePerson
    {
        [XmlElement("praw_regon9")]
        public override string Regon9 { get; set; }

        [XmlElement("praw_nip")]
        public string Nip { get; set; }

        [XmlElement("praw_statusNip")]
        public NipStatus NipStatus { get; set; }

        [XmlElement("praw_nazwa")]
        public override string Name { get; set; }

        [XmlElement("praw_nazwaSkrocona")]
        public override string ShortName { get; set; }

        [XmlElement("praw_numerWRejestrzeEwidencji")]
        public string NumberInRegisterOfRecords { get; set; }

        [XmlElement("praw_dataWpisuDoRejestruEwidencji")]
        public XmlDateTime DateOfEntryToRegisterOfRecords { get; set; }

        [XmlElement("praw_dataPowstania")]
        public override XmlDateTime DateOfCreation { get; set; }

        [XmlElement("praw_dataRozpoczeciaDzialalnosci")]
        public override XmlDateTime DateOfCommencementBusiness { get; set; }

        [XmlElement("praw_dataWpisuDoRegon")]
        public override XmlDateTime DateOfEntryToRegon { get; set; }

        [XmlElement("praw_dataZawieszeniaDzialalnosci")]
        public XmlDateTime DateOfSuspensionBusiness { get; set; }

        [XmlElement("praw_dataWznowieniaDzialalnosci")]
        public XmlDateTime DateOfResumptionBusiness { get; set; }

        [XmlElement("praw_dataZaistnieniaZmiany")]
        public override XmlDateTime DateOfChangeOccurrence { get; set; }

        [XmlElement("praw_dataZakonczeniaDzialalnosci")]
        public XmlDateTime BusinessTerminationDate { get; set; }

        [XmlElement("praw_dataSkresleniaZRegon")]
        public XmlDateTime DateOfDeletionFromRegon { get; set; }

        [XmlElement("praw_dataOrzeczeniaOUpadlosci")]
        public XmlDateTime DateOfDeclarationBankruptcy { get; set; }

        [XmlElement("praw_dataZakonczeniaPostepowaniaUpadlosciowego")]
        public XmlDateTime DateOfCompletionInsolvencyProceedings { get; set; }

        [XmlElement("praw_adSiedzKraj_Symbol")]
        public override string CountrySymbol { get; set; }

        [XmlElement("praw_adSiedzWojewodztwo_Symbol")]
        public override string ProvinceSymbol { get; set; }

        [XmlElement("praw_adSiedzPowiat_Symbol")]
        public override string CountySymbol { get; set; }

        [XmlElement("praw_adSiedzGmina_Symbol")]
        public override string CommuneSymbol { get; set; }

        [XmlElement("praw_adSiedzKodPocztowy")]
        public override string Postcode { get; set; }

        [XmlElement("praw_adSiedzMiejscowoscPoczty_Symbol")]
        public override string PostOfficeSymbol { get; set; }

        [XmlElement("praw_adSiedzMiejscowosc_Symbol")]
        public override string CitySymbol { get; set; }

        [XmlElement("praw_adSiedzUlica_Symbol")]
        public override string StreetSymbol { get; set; }

        [XmlElement("praw_adSiedzNumerNieruchomosci")]
        public override string PropertyNumber { get; set; }

        [XmlElement("praw_adSiedzNumerLokalu")]
        public override string ApartmentNumber { get; set; }

        [XmlElement("praw_adSiedzNietypoweMiejsceLokalizacji")]
        public string UnusualLocation { get; set; }

        [XmlElement("praw_numerTelefonu")]
        public override string PhoneNumber { get; set; }

        [XmlElement("praw_numerWewnetrznyTelefonu")]
        public string PhoneExtensionNumber { get; set; }

        [XmlElement("praw_numerFaksu")]
        public string FaxNumber { get; set; }

        [XmlElement("praw_adresEmail")]
        public override string Email { get; set; }

        [XmlElement("praw_adresStronyinternetowej")]
        public string Website { get; set; }

        [XmlElement("praw_adSiedzKraj_Nazwa")]
        public override string Country { get; set; }

        [XmlElement("praw_adSiedzWojewodztwo_Nazwa")]
        public override string Province { get; set; }

        [XmlElement("praw_adSiedzPowiat_Nazwa")]
        public override string County { get; set; }

        [XmlElement("praw_adSiedzGmina_Nazwa")]
        public override string Commune { get; set; }

        [XmlElement("praw_adSiedzMiejscowosc_Nazwa")]
        public override string City { get; set; }

        [XmlElement("praw_adSiedzMiejscowoscPoczty_Nazwa")]
        public override string PostOffice { get; set; }

        [XmlElement("praw_adSiedzUlica_Nazwa")]
        public override string Street { get; set; }

        [XmlElement("praw_podstawowaFormaPrawna_Symbol")]
        public string BasicLegalFormSymbol { get; set; }

        [XmlElement("praw_szczegolnaFormaPrawna_Symbol")]
        public string SpecificLegalFormSymbol { get; set; }

        [XmlElement("praw_formaFinansowania_Symbol")]
        public string FormOfFinancingSymbol { get; set; }

        [XmlElement("praw_formaWlasnosci_Symbol")]
        public string FormOfPropertySymbol { get; set; }

        [XmlElement("praw_organZalozycielski_Symbol")]
        public string FoundingBodySymbol { get; set; }

        [XmlElement("praw_organRejestrowy_Symbol")]
        public string RegistrationAuthoritySymbol { get; set; }

        [XmlElement("praw_rodzajRejestruEwidencji_Symbol")]
        public string RegistryTypeSymbol { get; set; }

        [XmlElement("praw_podstawowaFormaPrawna_Nazwa")]
        public string BasicLegalForm { get; set; }

        [XmlElement("praw_szczegolnaFormaPrawna_Nazwa")]
        public string SpecificLegalForm { get; set; }

        [XmlElement("praw_formaFinansowania_Nazwa")]
        public string FormOfFinancing { get; set; }

        [XmlElement("praw_formaWlasnosci_Nazwa")]
        public string FormOfProperty { get; set; }

        [XmlElement("praw_organZalozycielski_Nazwa")]
        public string FoundingBody { get; set; }

        [XmlElement("praw_organRejestrowy_Nazwa")]
        public string RegistrationAuthority { get; set; }

        [XmlElement("praw_rodzajRejestruEwidencji_Nazwa")]
        public string RegistryType { get; set; }

        [XmlElement("praw_liczbaJednLokalnych")]
        public int NumberOfLocalUnits { get; set; }
    }
}

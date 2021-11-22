using GusHelper.Utils;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    public abstract class BaseNaturalPersonBusiness : BasePerson
    {
        [XmlElement("fiz_regon9")]
        public override string Regon9 { get; set; }

        [XmlElement("fiz_nazwa")]
        public override string Name { get; set; }

        [XmlElement("fiz_nazwaSkrocona")]
        public override string ShortName { get; set; }

        [XmlElement("fiz_dataPowstania")]
        public override XmlDateTime DateOfCreation { get; set; }

        [XmlElement("fiz_dataRozpoczeciaDzialalnosci")]
        public override XmlDateTime DateOfCommencementBusiness { get; set; }

        [XmlElement("fiz_dataWpisuDzialalnosciDoRegon")]
        public override XmlDateTime DateOfEntryToRegon { get; set; }

        [XmlElement("fiz_dataZawieszeniaDzialalnosci")]
        public XmlDateTime DateOfSuspensionBusiness { get; set; }

        [XmlElement("fiz_dataWznowieniaDzialalnosci")]
        public XmlDateTime DateOfResumptionBusiness { get; set; }

        [XmlElement("fiz_dataZaistnieniaZmianyDzialalnosci")]
        public override XmlDateTime DateOfChangeOccurrence { get; set; }

        [XmlElement("fiz_dataZakonczeniaDzialalnosci")]
        public XmlDateTime BusinessTerminationDate { get; set; }

        [XmlElement("fiz_dataSkresleniaDzialalnosciZRegon")]
        public XmlDateTime DateOfDeletionFromRegon { get; set; }

        [XmlElement("fiz_adSiedzKraj_Symbol")]
        public override string CountrySymbol { get; set; }

        [XmlElement("fiz_adSiedzWojewodztwo_Symbol")]
        public override string ProvinceSymbol { get; set; }

        [XmlElement("fiz_adSiedzPowiat_Symbol")]
        public override string CountySymbol { get; set; }

        [XmlElement("fiz_adSiedzGmina_Symbol")]
        public override string CommuneSymbol { get; set; }

        [XmlElement("fiz_adSiedzKodPocztowy")]
        public string Postcode { get; set; }

        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Symbol")]
        public override string PostOfficeSymbol { get; set; }

        [XmlElement("fiz_adSiedzMiejscowosc_Symbol")]
        public override string CitySymbol { get; set; }

        [XmlElement("fiz_adSiedzUlica_Symbol")]
        public override string StreetSymbol { get; set; }

        [XmlElement("fiz_adSiedzNumerNieruchomosci")]
        public string PropertyNumber { get; set; }

        [XmlElement("fiz_adSiedzNumerLokalu")]
        public string ApartmentNumber { get; set; }

        [XmlElement("fiz_adSiedzNietypoweMiejsceLokalizacji")]
        public string UnusualLocation { get; set; }

        [XmlElement("fiz_numerTelefonu")]
        public override string PhoneNumber { get; set; }

        [XmlElement("fiz_numerWewnetrznyTelefonu")]
        public string PhoneExtensionNumber { get; set; }

        [XmlElement("fiz_numerFaksu")]
        public string FaxNumber { get; set; }

        [XmlElement("fiz_adresEmail")]
        public override string Email { get; set; }

        [XmlElement("fiz_adresStronyinternetowej")]
        public string Website { get; set; }

        [XmlElement("fiz_adSiedzKraj_Nazwa")]
        public override string Country { get; set; }

        [XmlElement("fiz_adSiedzWojewodztwo_Nazwa")]
        public override string Province { get; set; }

        [XmlElement("fiz_adSiedzPowiat_Nazwa")]
        public override string County { get; set; }

        [XmlElement("fiz_adSiedzGmina_Nazwa")]
        public override string Commune { get; set; }

        [XmlElement("fiz_adSiedzMiejscowosc_Nazwa")]
        public override string City { get; set; }

        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Nazwa")]
        public override string PostOffice { get; set; }

        [XmlElement("fiz_adSiedzUlica_Nazwa")]
        public override string Street { get; set; }
    }
}

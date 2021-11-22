using GusHelper.Utils;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class LegalPersonListOfLocalUnitsRoot
    {
        [XmlElement("dane")]
        public LegalPersonListOfLocalUnits Result { get; set; }
    }

    public class LegalPersonListOfLocalUnits
    {
        [XmlElement("lokpraw_regon14")]
        public string Regon14 { get; set; }

        [XmlElement("lokpraw_nazwa")]
        public string Name { get; set; }

        [XmlElement("lokpraw_adSiedzKraj_Symbol")]
        public string CountrySymbol { get; set; }

        [XmlElement("lokpraw_adSiedzWojewodztwo_Symbol")]
        public string ProvinceSymbol { get; set; }

        [XmlElement("lokpraw_adSiedzPowiat_Symbol")]
        public string CountySymbol { get; set; }

        [XmlElement("lokpraw_adSiedzGmina_Symbol")]
        public string CommuneSymbol { get; set; }

        [XmlElement("lokpraw_adSiedzKodPocztowy")]
        public string Postcode { get; set; }

        [XmlElement("lokpraw_adSiedzMiejscowoscPoczty_Symbol")]
        public string PostOfficeSymbol { get; set; }

        [XmlElement("lokpraw_adSiedzMiejscowosc_Symbol")]
        public string CitySymbol { get; set; }

        [XmlElement("lokpraw_adSiedzUlica_Symbol")]
        public string StreetSymbol { get; set; }

        [XmlElement("lokpraw_adSiedzNumerNieruchomosci")]
        public string PropertyNumber { get; set; }

        [XmlElement("lokpraw_adSiedzNumerLokalu")]
        public string ApartmentNumber { get; set; }

        [XmlElement("lokpraw_adSiedzNietypoweMiejsceLokalizacji")]
        public string UnusualLocation { get; set; }

        [XmlElement("lokpraw_adSiedzWojewodztwo_Nazwa")]
        public string Province { get; set; }

        [XmlElement("lokpraw_adSiedzPowiat_Nazwa")]
        public string County { get; set; }

        [XmlElement("lokpraw_adSiedzGmina_Nazwa")]
        public string Commune { get; set; }

        [XmlElement("lokpraw_adSiedzMiejscowosc_Nazwa")]
        public string City { get; set; }

        [XmlElement("lokpraw_adSiedzMiejscowoscPoczty_Nazwa")]
        public string PostOffice { get; set; }

        [XmlElement("lokpraw_adSiedzUlica_Nazwa")]
        public string Street { get; set; }

        [XmlElement("lokpraw_dataPowstania")]
        public XmlDateTime DateOfCreation { get; set; }

        [XmlElement("lokpraw_dataRozpoczeciaDzialalnosci")]
        public XmlDateTime DateOfCommencementBusiness { get; set; }

        [XmlElement("lokpraw_dataWpisuDoRegon")]
        public XmlDateTime DateOfEntryToRegon { get; set; }

        [XmlElement("lokpraw_dataZawieszeniaDzialalnosci")]
        public XmlDateTime DateOfSuspensionBusiness { get; set; }

        [XmlElement("lokpraw_dataWznowieniaDzialalnosci")]
        public XmlDateTime DateOfResumptionBusiness { get; set; }

        [XmlElement("lokpraw_dataZakonczeniaDzialalnosci")]
        public XmlDateTime BusinessTerminationDate { get; set; }

        [XmlElement("lokpraw_dataSkresleniaZRegon")]
        public XmlDateTime DateOfDeletionFromRegon { get; set; }
    }
}

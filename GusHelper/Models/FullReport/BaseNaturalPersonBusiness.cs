using GusHelper.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    public abstract class BaseNaturalPersonBusiness
    {
        [XmlElement("fiz_regon9")]
        public string Regon9 { get; set; }

        [XmlElement("fiz_nazwa")]
        public string Name { get; set; }

        [XmlElement("fiz_nazwaSkrocona")]
        public string ShortName { get; set; }

        [XmlElement("fiz_dataPowstania")]
        public XmlDateTime DateOfCreation { get; set; }

        [XmlElement("fiz_dataRozpoczeciaDzialalnosci")]
        public XmlDateTime DateOfCommencementBusiness { get; set; }

        [XmlElement("fiz_dataWpisuDzialalnosciDoRegon")]
        public XmlDateTime DateOfEntryToRegon { get; set; }

        [XmlElement("fiz_dataZawieszeniaDzialalnosci")]
        public XmlDateTime DateOfSuspensionBusiness { get; set; }

        [XmlElement("fiz_dataWznowieniaDzialalnosci")]
        public XmlDateTime DateOfResumptionBusiness { get; set; }

        [XmlElement("fiz_dataZaistnieniaZmianyDzialalnosci")]
        public XmlDateTime DateOfChangeOccurrence { get; set; }

        [XmlElement("fiz_dataZakonczeniaDzialalnosci")]
        public XmlDateTime BusinessTerminationDate { get; set; }

        [XmlElement("fiz_dataSkresleniaDzialalnosciZRegon")]
        public XmlDateTime DateOfDeletionFromRegon { get; set; }

        [XmlElement("fiz_adSiedzKraj_Symbol")]
        public string CountrySymbol { get; set; }

        [XmlElement("fiz_adSiedzWojewodztwo_Symbol")]
        public string ProvinceSymbol { get; set; }

        [XmlElement("fiz_adSiedzPowiat_Symbol")]
        public string CountySymbol { get; set; }

        [XmlElement("fiz_adSiedzGmina_Symbol")]
        public string CommuneSymbol { get; set; }

        [XmlElement("fiz_adSiedzKodPocztowy")]
        public string Postcode { get; set; }

        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Symbol")]
        public string PostOfficeSymbol { get; set; }

        [XmlElement("fiz_adSiedzMiejscowosc_Symbol")]
        public string CitySymbol { get; set; }

        [XmlElement("fiz_adSiedzUlica_Symbol")]
        public string StreetSymbol { get; set; }

        [XmlElement("fiz_adSiedzNumerNieruchomosci")]
        public string PropertyNumber { get; set; }

        [XmlElement("fiz_adSiedzNumerLokalu")]
        public string ApartmentNumber { get; set; }

        [XmlElement("fiz_adSiedzNietypoweMiejsceLokalizacji")]
        public string UnusualLocation { get; set; }

        [XmlElement("fiz_numerTelefonu")]
        public string PhoneNumber { get; set; }

        [XmlElement("fiz_numerWewnetrznyTelefonu")]
        public string PhoneExtensionNumber { get; set; }

        [XmlElement("fiz_numerFaksu")]
        public string FaxNumber { get; set; }

        [XmlElement("fiz_adresEmail")]
        public string Email { get; set; }

        [XmlElement("fiz_adresStronyinternetowej")]
        public string Website { get; set; }

        [XmlElement("fiz_adSiedzKraj_Nazwa")]
        public string Country { get; set; }

        [XmlElement("fiz_adSiedzWojewodztwo_Nazwa")]
        public string Province { get; set; }

        [XmlElement("fiz_adSiedzPowiat_Nazwa")]
        public string County { get; set; }

        [XmlElement("fiz_adSiedzGmina_Nazwa")]
        public string Commune { get; set; }

        [XmlElement("fiz_adSiedzMiejscowosc_Nazwa")]
        public string City { get; set; }

        [XmlElement("fiz_adSiedzMiejscowoscPoczty_Nazwa")]
        public string PostOffice { get; set; }

        [XmlElement("fiz_adSiedzUlica_Nazwa")]
        public string Street { get; set; }
    }
}

using GusHelper.Utils;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace GusHelper.Models.DataSearchEntitiesResult
{

    [XmlRoot("root")]
    public class SearchEntityRoot
    {
        [XmlElement("dane")]
        public List<SearchEntity> Results { get; set; }
    }


    public class SearchEntity
    {
        public string Regon { get; set; }
        public string Nip { get; set; }

        [XmlElement("StatusNip")]
        public NipStatus NipStatus { get; set; }

        [XmlElement("Nazwa")]
        public string Name { get; set; }

        [XmlElement("Wojewodztwo")]
        public string Province { get; set; }

        [XmlElement("Powiat")]
        public string County { get; set; }

        [XmlElement("Gmina")]
        public string Commune { get; set; }

        [XmlElement("Miejscowosc")]
        public string City { get; set; }

        [XmlElement("KodPocztowy")]
        public string Postcode { get; set; }

        [XmlElement("Ulica")]
        public string Street { get; set; }

        [XmlElement("NrNieruchomosci")]
        public string PropertyNumber { get; set; }

        [XmlElement("NrLokalu")]
        public string ApartmentNumber { get; set; }

        [XmlElement("Typ")]
        public string Type { get; set; }

        public int SilosID { get; set; }

        [XmlElement("DataZakonczeniaDzialalnosci")]
        public XmlDateTime BusinessEndDate { get; set; }

        [XmlElement("MiejscowoscPoczty")]
        public string PostOffice { get; set; }
    }
}

using GusHelper.Utils;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [XmlRoot("root")]
    public class NaturalPersonAllRoot
    {
        [XmlElement("dane")]
        public NaturalPersonAll Result { get; set; }
    }

    public class NaturalPersonAll
    {
        [XmlElement("fiz_regon9")]
        public string Regon9 { get; set; }

        [XmlElement("fiz_nip")]
        public string Nip { get; set; }

        [XmlElement("fiz_statusNip")]
        public NipStatus NipStatus { get; set; }

        [XmlElement("fiz_nazwisko")]
        public string LastName { get; set; }

        [XmlElement("fiz_imie1")]
        public string FirstName { get; set; }

        [XmlElement("fiz_imie2")]
        public string SecondName { get; set; }

        [XmlElement("fiz_dataWpisuPodmiotuDoRegon")]
        public XmlDateTime DateOfEntryEntityToRegon { get; set; }

        [XmlElement("fiz_dataZaistnieniaZmiany")]
        public XmlDateTime DateOfChangeOccurrence { get; set; }

        [XmlElement("fiz_dataSkresleniaPodmiotuZRegon")]
        public XmlDateTime DateOfDeletionEntityFromRegon { get; set; }

        [XmlElement("fiz_podstawowaFormaPrawna_Symbol")]
        public string BasicLegalFormSymbol { get; set; }

        [XmlElement("fiz_szczegolnaFormaPrawna_Symbol")]
        public string SpecificLegalFormSymbol { get; set; }

        [XmlElement("fiz_formaFinansowania_Symbol")]
        public string FormOfFinancingSymbol { get; set; }

        [XmlElement("fiz_formaWlasnosci_Symbol")]
        public string FormOfPropertySymbol { get; set; }

        [XmlElement("fiz_podstawowaFormaPrawna_Nazwa")]
        public string BasicLegalForm { get; set; }

        [XmlElement("fiz_szczegolnaFormaPrawna_Nazwa")]
        public string SpecificLegalForm { get; set; }

        [XmlElement("fiz_formaFinansowania_Nazwa")]
        public string FormOfFinancing { get; set; }

        [XmlElement("fiz_formaWlasnosci_Nazwa")]
        public string FormOfProperty { get; set; }

        [XmlElement("fiz_dzialalnoscCeidg")]
        public int EconomicBusiness { get; set; }

        [XmlElement("fiz_dzialalnoscRolnicza")]
        public int AgriculturalBusiness { get; set; }

        [XmlElement("fiz_dzialalnoscPozostala")]
        public int OtherBusiness { get; set; }

        [XmlElement("fiz_dzialalnoscSkreslonaDo20141108")]
        public int DeletedBusiness { get; set; }

        [XmlElement("fiz_liczbaJednLokalnych")]
        public int NumberOfLocalUnits { get; set; }
    }
}

using GusHelper.Utils;
using System;
using System.Xml.Serialization;

namespace GusHelper.Models.FullReport
{
    [Serializable]
    public abstract class BasePerson
    {
        [XmlIgnore]
        public virtual string Regon9 { get; set; }
        [XmlIgnore]
        public virtual string Name { get; set; }
        [XmlIgnore]
        public virtual string ShortName { get; set; }
        [XmlIgnore]
        public virtual XmlDateTime DateOfCreation { get; set; }
        [XmlIgnore]
        public virtual XmlDateTime DateOfCommencementBusiness { get; set; }
        [XmlIgnore]
        public virtual XmlDateTime DateOfEntryToRegon { get; set; }
        [XmlIgnore]
        public virtual XmlDateTime DateOfChangeOccurrence { get; set; }
        [XmlIgnore]
        public virtual string PhoneNumber { get; set; }
        [XmlIgnore]
        public virtual string Email { get; set; }
        [XmlIgnore]
        public virtual string CountrySymbol { get; set; }
        [XmlIgnore]
        public virtual string ProvinceSymbol { get; set; }
        [XmlIgnore]
        public virtual string CountySymbol { get; set; }
        [XmlIgnore]
        public virtual string CommuneSymbol { get; set; }
        [XmlIgnore]
        public virtual string PostOfficeSymbol { get; set; }
        [XmlIgnore]
        public virtual string CitySymbol { get; set; }
        [XmlIgnore]
        public virtual string StreetSymbol { get; set; }
        [XmlIgnore]
        public virtual string Country { get; set; }
        [XmlIgnore]
        public virtual string Province { get; set; }
        [XmlIgnore]
        public virtual string County { get; set; }
        [XmlIgnore]
        public virtual string Commune { get; set; }
        [XmlIgnore]
        public virtual string PostOffice { get; set; }
        [XmlIgnore]
        public virtual string City { get; set; }
        [XmlIgnore]
        public virtual string Street { get; set; }
    }
}

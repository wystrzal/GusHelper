using GusHelper.Models.FullReport;
using GusHelper.ViewModels;
using GusHelper.ViewModels.AddressViewModels;
using System;

namespace GusHelper.Utils
{
    public static class BasePersonMapper
    {
        public static void MapBaseData(DataOfPersonBusiness data, BasePerson basePerson)
        {
            if (data == null || basePerson == null) throw new NullReferenceException();

            data.Regon9 = basePerson.Regon9;
            data.Name = basePerson.Name;
            data.ShortName = basePerson.ShortName;
            data.DateOfCreation = basePerson.DateOfCreation.DateTime;
            data.DateOfCommencementBusiness = basePerson.DateOfCommencementBusiness.DateTime;
            data.DateOfEntryToRegon = basePerson.DateOfEntryToRegon.DateTime;
            data.DateOfChangeOccurrence = basePerson.DateOfChangeOccurrence.DateTime;
            data.PhoneNumber = basePerson.PhoneNumber;
            data.Email = basePerson.Email;
        }

        public static void MapAddress(DataOfPersonBusiness data, BasePerson basePerson)
        {
            if (data == null || basePerson == null) throw new NullReferenceException();

            data.Address = new Address();
            if (!string.IsNullOrWhiteSpace(basePerson.City))
            {
                var city = new City { Name = basePerson.City, Symbol = basePerson.CitySymbol, Postcode = basePerson.Postcode };
                data.Address.City = city;
            }
            if (!string.IsNullOrWhiteSpace(basePerson.PostOffice))
            {
                var postOffice = new City { Name = basePerson.PostOffice, Symbol = basePerson.PostOfficeSymbol, Postcode = basePerson.Postcode };
                data.Address.PostOffice = postOffice;
            }
            if (!string.IsNullOrWhiteSpace(basePerson.Commune))
            {
                var commune = new Commune { Name = basePerson.Commune, Symbol = basePerson.CommuneSymbol };
                data.Address.Commune = commune;
            }
            if (!string.IsNullOrWhiteSpace(basePerson.Country))
            {
                var country = new Country { Name = basePerson.Country, Symbol = basePerson.CountrySymbol };
                data.Address.Country = country;
            }
            if (!string.IsNullOrWhiteSpace(basePerson.County))
            {
                var county = new County { Name = basePerson.County, Symbol = basePerson.CountySymbol };
                data.Address.County = county;
            }
            if (!string.IsNullOrWhiteSpace(basePerson.Province))
            {
                var province = new Province { Name = basePerson.Province, Symbol = basePerson.ProvinceSymbol };
                data.Address.Province = province;
            }
            if (!string.IsNullOrWhiteSpace(basePerson.Street))
            {
                var street = new Street { Name = basePerson.Street, Symbol = basePerson.StreetSymbol, ApartmentNumber = basePerson.ApartmentNumber, PropertyNumber = basePerson.PropertyNumber };
                data.Address.Street = street;
            }
        }
    }
}
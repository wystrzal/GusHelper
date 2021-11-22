using GusHelper.Models.FullReport;
using GusHelper.ViewModels;
using GusHelper.ViewModels.OrganizationViewModels;
using System;

namespace GusHelper.Utils
{
    public static class NaturalPersonMapper
    {
        public static void MapOrganizationData(DataOfPersonBusiness data, NaturalPersonAll naturalPerson)
        {
            if (data == null || naturalPerson == null) throw new NullReferenceException();

            if (data.OrganizationData == null)
            {
                data.OrganizationData = new OrganizationData();
            }
            if (!string.IsNullOrWhiteSpace(naturalPerson.BasicLegalForm))
            {
                data.OrganizationData.BasicLegalForm = new BasicLegalForm { Name = naturalPerson.BasicLegalForm, Symbol = naturalPerson.BasicLegalFormSymbol };
            }
            if (!string.IsNullOrWhiteSpace(naturalPerson.FormOfFinancing))
            {
                data.OrganizationData.FinancingForm = new FinancingForm { Name = naturalPerson.FormOfFinancing, Symbol = naturalPerson.FormOfFinancingSymbol };
            }
            if (!string.IsNullOrWhiteSpace(naturalPerson.FormOfProperty))
            {
                data.OrganizationData.PropertyForm = new PropertyForm { Name = naturalPerson.FormOfProperty, Symbol = naturalPerson.FormOfPropertySymbol };
            }
            if (!string.IsNullOrWhiteSpace(naturalPerson.SpecificLegalForm))
            {
                data.OrganizationData.SpecificLegalForm = new SpecificLegalForm { Name = naturalPerson.SpecificLegalForm, Symbol = naturalPerson.SpecificLegalFormSymbol };
            }
        }

        public static void MapOrganizationData(DataOfPersonBusiness data, NaturalPersonEconomicBusiness naturalPerson)
        {
            if (data == null || naturalPerson == null) throw new NullReferenceException();

            data.OrganizationData = new OrganizationData();
            if (!string.IsNullOrWhiteSpace(naturalPerson.RegistrationAuthority))
            {
                data.OrganizationData.RegistrationAuthority = new RegistrationAuthority { Name = naturalPerson.RegistrationAuthority, Symbol = naturalPerson.RegistrationAuthoritySymbol };
            }
            if (!string.IsNullOrWhiteSpace(naturalPerson.RegistryType))
            {
                data.OrganizationData.RegistryType = new RegistryType { Name = naturalPerson.RegistryType, Symbol = naturalPerson.RegistryTypeSymbol };
            }
        }

        public static void MapOrganizationData(DataOfPersonBusiness data, NaturalPersonOtherBusiness naturalPerson)
        {
            if (data == null || naturalPerson == null) throw new NullReferenceException();

            data.OrganizationData = new OrganizationData();
            if (!string.IsNullOrWhiteSpace(naturalPerson.RegistrationAuthority))
            {
                data.OrganizationData.RegistrationAuthority = new RegistrationAuthority { Name = naturalPerson.RegistrationAuthority, Symbol = naturalPerson.RegistrationAuthoritySymbol };
            }
            if (!string.IsNullOrWhiteSpace(naturalPerson.RegistryType))
            {
                data.OrganizationData.RegistryType = new RegistryType { Name = naturalPerson.RegistryType, Symbol = naturalPerson.RegistryTypeSymbol };
            }
        }
    }
}

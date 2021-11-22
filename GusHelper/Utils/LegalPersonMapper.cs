using GusHelper.Models.FullReport;
using GusHelper.ViewModels;
using GusHelper.ViewModels.OrganizationViewModels;
using System;

namespace GusHelper.Utils
{
    public static class LegalPersonMapper
    {
        public static void MapOrganizationData(DataOfPersonBusiness data, LegalPerson legalPerson)
        {
            if (data == null || legalPerson == null) throw new NullReferenceException();

            data.OrganizationData = new OrganizationData();
            if (!string.IsNullOrWhiteSpace(legalPerson.BasicLegalForm))
            {
                data.OrganizationData.BasicLegalForm = new BasicLegalForm { Name = legalPerson.BasicLegalForm, Symbol = legalPerson.BasicLegalFormSymbol };
            }
            if (!string.IsNullOrWhiteSpace(legalPerson.FormOfFinancing))
            {
                data.OrganizationData.FinancingForm = new FinancingForm { Name = legalPerson.FormOfFinancing, Symbol = legalPerson.FormOfFinancingSymbol };
            }
            if (!string.IsNullOrWhiteSpace(legalPerson.FoundingBody))
            {
                data.OrganizationData.FoundingBody = new FoundingBody { Name = legalPerson.FoundingBody, Symbol = legalPerson.FoundingBodySymbol };
            }
            if (!string.IsNullOrWhiteSpace(legalPerson.FormOfProperty))
            {
                data.OrganizationData.PropertyForm = new PropertyForm { Name = legalPerson.FormOfProperty, Symbol = legalPerson.FormOfPropertySymbol };
            }
            if (!string.IsNullOrWhiteSpace(legalPerson.RegistrationAuthority))
            {
                data.OrganizationData.RegistrationAuthority = new RegistrationAuthority { Name = legalPerson.RegistrationAuthority, Symbol = legalPerson.RegistrationAuthoritySymbol };
            }
            if (!string.IsNullOrWhiteSpace(legalPerson.RegistryType))
            {
                data.OrganizationData.RegistryType = new RegistryType { Name = legalPerson.RegistryType, Symbol = legalPerson.RegistryTypeSymbol };
            }
            if (!string.IsNullOrWhiteSpace(legalPerson.SpecificLegalForm))
            {
                data.OrganizationData.SpecificLegalForm = new SpecificLegalForm { Name = legalPerson.SpecificLegalForm, Symbol = legalPerson.SpecificLegalFormSymbol };
            }
        }
    }
}

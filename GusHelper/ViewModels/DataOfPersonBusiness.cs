using GusHelper.ViewModels.AddressViewModels;
using GusHelper.ViewModels.OrganizationViewModels;
using System;
using System.Collections.Generic;

namespace GusHelper.ViewModels
{
    public class DataOfPersonBusiness
    {
        public string Regon9 { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string NumberInRegisterOfRecords { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfCommencementBusiness { get; set; }
        public DateTime DateOfEntryToRegon { get; set; }
        public DateTime DateOfEntryToRegisterOfRecords { get; set; }
        public DateTime DateOfChangeOccurrence { get; set; }
        public DateTime BusinessTerminationDate { get; set; }
		public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public OrganizationData OrganizationData { get; set; }
        public Address Address { get; set; }
        public List<Pkd> PkdList { get; set; } = new List<Pkd>();
    }
}

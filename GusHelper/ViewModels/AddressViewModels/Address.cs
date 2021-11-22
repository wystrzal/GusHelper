namespace GusHelper.ViewModels.AddressViewModels
{
    public class Address
    {
        public City City { get; set; }
        public City PostOffice { get; set; }
        public Commune Commune { get; set; }
        public Country Country { get; set; }
        public County County { get; set; }
        public Province Province { get; set; }
        public Street Street { get; set; }
    }
}

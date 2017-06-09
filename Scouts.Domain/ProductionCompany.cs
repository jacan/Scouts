namespace Scouts.Domain
{
    public class ProductionCompany
    {
        public ProductionCompany(string companyName, Address address, ContactInformation contactInformation)
        {
            CompanyName = companyName;
            Address = address;
            ContactInformation = contactInformation;
        }

        public string CompanyName { get; private set; }
        public Address Address { get; private set; }
        public ContactInformation ContactInformation { get; private set; }
    }
}

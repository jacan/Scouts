namespace Scouts.Domain
{
    public class ProductionCompany : Aggregate
    {
        public ProductionCompany(
            DomainId companyId,
            DomainId locationManagersId,
            string companyName, 
            Schedule productionSchedule, 
            Address address, 
            ContactInformation contactInformation)

            : base(companyId)
        {
            LocationManagersId = locationManagersId;
            CompanyName = companyName;
            Schedule = productionSchedule;
            Address = address;
            ContactInformation = contactInformation;
        }

        public DomainId LocationManagersId { get; }

        public string CompanyName { get; set; }
        public Address Address { get; set; }
        public ContactInformation ContactInformation { get; set; }
        
        public Schedule Schedule { get; }
    }
}

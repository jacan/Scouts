using System;

namespace Scouts.Domain.Staff
{
    public class LocationScout : Person
    {
        public LocationScout(DomainId locationScoutsId, string firstName, string lastName, DateTime dateOfBirth, Portfolio portFolio = null)
            : base(locationScoutsId, firstName, lastName, dateOfBirth)
        {
            Portfolio = portFolio ?? new Portfolio();
        }

        public Portfolio Portfolio { get; private set; }
    }
}

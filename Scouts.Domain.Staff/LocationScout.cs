using System;

namespace Scouts.Domain.Staff
{
    public class LocationScout : Person
    {
        public LocationScout(string firstName, string lastName, DateTime dateOfBirth, Portfolio portFolio = null)
            : base(firstName, lastName, dateOfBirth)
        {
            Portfolio = portFolio ?? new Portfolio();
        }

        public Portfolio Portfolio { get; private set; }
    }
}

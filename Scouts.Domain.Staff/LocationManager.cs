using System;
using System.Collections.Generic;
using System.Linq;

namespace Scouts.Domain.Staff
{
    public class LocationManager : Person
    {
        public LocationManager(ProductionCompany productionCompany, string firstName, string lastName, DateTime dateOfBirth, IEnumerable<LocationScout> scouts)
            : base(productionCompany.LocationManagersId, firstName, lastName, dateOfBirth)
        {
            Scouts = scouts.ToList();
        }

        public List<LocationScout> Scouts { get; private set; }
    }
}

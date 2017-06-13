using System;
using System.Collections.Generic;
using System.Linq;

namespace Scouts.Domain.Staff
{
    public class LocationManager : Person
    {
        public LocationManager(DomainId locationManagersId, string firstName, string lastName, DateTime dateOfBirth, IEnumerable<LocationScout> scouts)
            : base(locationManagersId, firstName, lastName, dateOfBirth)
        {
            Scouts = scouts.ToList();
        }

        public List<LocationScout> Scouts { get; private set; }
    }
}

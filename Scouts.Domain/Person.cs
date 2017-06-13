using System;

namespace Scouts.Domain
{
    public class  Person : Aggregate
    {
        public Person(DomainId personsId,  string firstName, string lastName, DateTime dateOfBirth)
            : base(personsId)
        {
            Firstname = firstName;
            Lastname = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public DateTime DateOfBirth { get; private set; }
    }
}

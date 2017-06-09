using System;

namespace Scouts.Domain
{
    public class Person
    {
        public Person(string firstName, string lastName, DateTime dateOfBirth)
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

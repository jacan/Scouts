using System;

namespace Scouts.Domain
{
    public class InvalidDomainIdException : Exception
    {
        public InvalidDomainIdException()
            : base("The Domain ID provided is invalid!")
        {

        }
    }
}

using System.Collections.Generic;

namespace Scouts.Domain
{
    public class Address
    {
        public Address(IEnumerable<string> addressLines, PostalCode postalCode)
        {
            AddressLines = addressLines;
            PostalCode = postalCode;
        }

        public IEnumerable<string> AddressLines { get; private set; }
        public PostalCode PostalCode { get; private set; }
    }
}
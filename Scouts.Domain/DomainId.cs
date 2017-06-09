using System;

namespace Scouts.Domain
{
    public class DomainId
    {
        // Might internal
        public DomainId(Guid rawId)
        {
            if(rawId == Guid.Empty)
            {
                throw new InvalidDomainIdException();
            }

            RawId = rawId;
        }

        public Guid RawId { get; private set; }

        public static implicit operator DomainId(Guid rawId)
        {
            if(rawId == Guid.Empty)
            {
                throw new InvalidDomainIdException();
            }

            return new DomainId(rawId);
        }

        public static implicit operator Guid(DomainId domainId)
        {
            return domainId.RawId;
        }
    }
}

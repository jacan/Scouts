using System;

namespace Scouts.Domain
{
    /// <summary>
    /// Base level domain factory
    /// </summary>
    public static class DomainFactory
    {
        public static DomainId CreateId()
        {
            return new DomainId(Guid.NewGuid());
        }
    }
}

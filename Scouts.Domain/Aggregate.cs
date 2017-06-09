namespace Scouts.Domain
{
    public abstract class Aggregate
    {
        public Aggregate(DomainId id)
        {
            Id = id;
        }

        public DomainId Id { get; }
    }
}

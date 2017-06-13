namespace Scouts.Domain.PhotoLibrary
{
    public class PhotoRelations
    {
        public PhotoRelations(DomainId productionCompanyId, DomainId locationScoutsId, DomainId locationManagersId)
        {
            ProductionCompanyId = productionCompanyId;
            LocationScoutId = locationScoutsId;
            LocationManagerId = locationManagersId;
        }

        public DomainId ProductionCompanyId { get; }
        public DomainId LocationScoutId { get; }
        public DomainId LocationManagerId { get; }

        // TODO: What other important relations are important here.
    }
}
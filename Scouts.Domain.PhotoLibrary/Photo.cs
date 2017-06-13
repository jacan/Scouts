namespace Scouts.Domain.PhotoLibrary
{
    public class Photo : Aggregate, IAsset
    {
        public Photo(DomainId photoId, RawImage image, PhotoMetaData metaData, PhotoDescription description, PhotoRelations relations)
            :base(photoId)
        {
            Image = image;
            MetaData = metaData;
            Description = description;
            Relations = relations;
        }

        public RawImage Image { get; }
        public PhotoMetaData MetaData { get; }
        public PhotoDescription Description { get; }
        public PhotoRelations Relations { get; }
    }
}

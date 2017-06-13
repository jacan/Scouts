namespace Scouts.Domain.PhotoLibrary
{
    public class GpsInformation
    {
        public GpsInformation(long longtitude, long latitude)
        {
            Longtitude = longtitude;
            Latitude = latitude;
        }

        public long Longtitude { get; }
        public long Latitude { get; }
    }
}
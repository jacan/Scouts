namespace Scouts.Domain.PhotoLibrary
{
    public class PhotoMetaData
    {
        public PhotoMetaData(int width, int height, long pixelCount, GpsInformation gpsData)
        {
            With = width;
            Height = height;
            PixelCount = pixelCount;
            GpsData = gpsData;
        }

        public int With { get; }
        public int Height { get; }
        public long PixelCount { get; }
        public GpsInformation GpsData { get; }
    }
}
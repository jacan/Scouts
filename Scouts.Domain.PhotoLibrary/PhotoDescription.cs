using System.Linq;
using System.Collections.Generic;

namespace Scouts.Domain.PhotoLibrary
{
    public class PhotoDescription
    {
        public PhotoDescription(string title, string description, IEnumerable<CustomValueDescriptor> extendedDescriptions)
        {
            Title = title;
            Description = description;
            ExtendedDescriptions = extendedDescriptions.ToList();
        }
        
        public string Title { get; }
        public string Description { get; }
        public List<CustomValueDescriptor> ExtendedDescriptions { get; }
    }
}
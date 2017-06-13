using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scouts.Domain.PhotoLibrary
{
    public class RawImage
    {
        public RawImage(byte[] imageSource)
        {
            ImageSource = imageSource;
        }

        public byte[] ImageSource { get; }

    }
}

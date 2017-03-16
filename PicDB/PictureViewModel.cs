using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class PictureViewModel : IPictureViewModel
    {
        public ICameraViewModel Camera
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string DisplayName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEXIFViewModel EXIF
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string FileName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string FilePath
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ID
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IIPTCViewModel IPTC
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPhotographerViewModel Photographer
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}

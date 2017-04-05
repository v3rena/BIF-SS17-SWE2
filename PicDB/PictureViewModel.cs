using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;


namespace PicDB
{
    class PictureViewModel : IPictureViewModel
    {
        public PictureViewModel()
        { }
        public PictureViewModel(PictureModel mdl)
        {
            this.mdl = mdl;
            this.FileName = mdl.FileName;
            this.EXIF = new EXIFViewModel((EXIFModel)mdl.EXIF);
            this.IPTC = new IPTCViewModel((IPTCModel)mdl.IPTC);
            this.DisplayName = this.IPTC.Headline + " (by " +  this.IPTC.ByLine + ")";
        }
        public ICameraViewModel Camera
        {
            get
            {
                return new CameraViewModel((CameraModel)this.mdl.Camera);
            }
        }

        public string DisplayName
        {
            get; set;
        }

        public IEXIFViewModel EXIF
        {
            get; set;
        }

        public string FileName
        {
            get; set;
        }

        public string FilePath
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }

        public IIPTCViewModel IPTC
        {
            get; set;
        }

        public IPhotographerViewModel Photographer
        {
            get; set;
        }

        private PictureModel mdl
        {
            get; set;
        }
    }
}

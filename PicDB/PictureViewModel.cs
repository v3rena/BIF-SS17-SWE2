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
            this.FileName = mdl.FileName;
            this.EXIF = new EXIFViewModel((EXIFModel)mdl.EXIF);
            this.IPTC = new IPTCViewModel((IPTCModel)mdl.IPTC);
            this.DisplayName = this.IPTC.Headline + " (by " +  this.IPTC.ByLine + ")";
        }
        public ICameraViewModel Camera
        {
            get;
        }

        public string DisplayName
        {
            get;
        }

        public IEXIFViewModel EXIF
        {
            get;
        }

        public string FileName
        {
            get; set;
        }

        public string FilePath
        {
            get;
        }

        public int ID
        {
            get;
        }

        public IIPTCViewModel IPTC
        {
            get;
        }

        public IPhotographerViewModel Photographer
        {
            get;
        }
    }
}

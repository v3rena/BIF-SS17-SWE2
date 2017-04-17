using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;
using BIF.SWE2.Interfaces.Models;


namespace PicDB
{
    class PictureViewModel : IPictureViewModel
    {
        public PictureViewModel()
        { }
        public PictureViewModel(PictureModel mdl)
        {
            pmdl = mdl;
            /*
            this.FileName = mdl.FileName;
            this.EXIF = new EXIFViewModel((EXIFModel)mdl.EXIF);
            this.IPTC = new IPTCViewModel((IPTCModel)mdl.IPTC);
            this.DisplayName = this.IPTC.Headline + " (by " +  this.IPTC.ByLine + ")";*/
        }
        public ICameraViewModel Camera
        {
            get
            {
                return new CameraViewModel((CameraModel)pmdl.Camera);
            }
        }

        public string DisplayName
        {
            get
            {
                return IPTC.Headline + " (by " + IPTC.ByLine + ")";
            }
        }

        public IEXIFViewModel EXIF
        {
            get
            {
                if(exmdl == null)
                {
                    exmdl = new EXIFViewModel((EXIFModel)pmdl.EXIF);
                }
                return exmdl;
            }
        }

        public string FileName
        {
            get
            {
                return pmdl.FileName;
            }
        }

        public string FilePath
        {
            get;
        }

        public int ID
        {
            get
            {
                return pmdl.ID;
            }
        }

        public IIPTCViewModel IPTC
        {
            get
            {
                if (ipmdl == null)
                {
                    ipmdl = new IPTCViewModel((IPTCModel)pmdl.IPTC);
                }
                return ipmdl;
            }
        }

        public IPhotographerViewModel Photographer
        {
            get;
        }

        private IPictureModel pmdl;
        private IIPTCViewModel ipmdl;
        private IEXIFViewModel exmdl;
        private IPhotographerViewModel phmdl;
    }
}

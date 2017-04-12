using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    class EXIFViewModel : IEXIFViewModel
    {
		ICameraViewModel cameraView;
		IEXIFModel exifMdl;

		public EXIFViewModel()
        {
			exifMdl = new EXIFModel();
		}
        public EXIFViewModel(EXIFModel emdl)
        {
			exifMdl = emdl;

			/*ExposureProgram = emdl.ExposureProgram.ToString();
            //ExposureProgramResource
            ExposureTime = emdl.ExposureTime;
            Flash = emdl.Flash;
            FNumber = emdl.FNumber;
            //ISORating
            //ISORatingResource
            ISOValue = emdl.ISOValue;
            Make = emdl.Make;*/
		}

		/*public EXIFViewModel(IPictureModel pictureModel) : this()
		{
			cameraView = new CameraViewModel(pictureModel.Camera);
		}*/

		public ICameraViewModel Camera
        {
			get
			{
				return cameraView;
			}

			set
			{
				cameraView = value;
			}
		}

        public string ExposureProgram
		{
			get
			{
				return exifMdl.ExposureProgram.ToString();
			}
		}

        public string ExposureProgramResource
		{
			get
			{
				return exifMdl.ExposureProgram.ToString();
			}
		}

        public decimal ExposureTime
        {
			get
			{
				return exifMdl.ExposureTime;
			}
		}

        public bool Flash
        {
			get
			{
				return exifMdl.Flash;
			}
		}

        public decimal FNumber
        {
			get
			{
				return exifMdl.FNumber;
			}
		}

        public ISORatings ISORating
        {
			get
			{
				if (exifMdl.ISOValue >= 100 && exifMdl.ISOValue < 800)
				{
					return ISORatings.Good;
				}
				else if (exifMdl.ISOValue >= 800 && exifMdl.ISOValue < 1600)
				{
					return ISORatings.Acceptable;
				}
				else if (exifMdl.ISOValue >= 1600)
				{
					return ISORatings.Noisey;
				}
				else
				{
					return ISORatings.NotDefined;
				}
			}
		}

        public string ISORatingResource
		{
			get
			{
				return ISORating.ToString();
			}
		}

        public decimal ISOValue
        {
			get
			{
				return exifMdl.ISOValue;
			}
		}

        public string Make
        {
			get
			{
				return exifMdl.Make;
			}
		}
    }
}

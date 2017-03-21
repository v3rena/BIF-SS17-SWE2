using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class EXIFViewModel : IEXIFViewModel
    {
        public EXIFViewModel()
        { }
        public EXIFViewModel(EXIFModel emdl)
        {
            ExposureProgram = emdl.ExposureProgram.ToString();
            //ExposureProgramResource
            ExposureTime = emdl.ExposureTime;
            Flash = emdl.Flash;
            FNumber = emdl.FNumber;
            //ISORating
            //ISORatingResource
            ISOValue = emdl.ISOValue;
            Make = emdl.Make;
        }
        public ICameraViewModel Camera
        {
            get; set;
        }

        public string ExposureProgram
        {
            get;
        }

        public string ExposureProgramResource
        {
            get;
        }

        public decimal ExposureTime
        {
            get;
        }

        public bool Flash
        {
            get;
        }

        public decimal FNumber
        {
            get;
        }

        public ISORatings ISORating
        {
            get;
        }

        public string ISORatingResource
        {
            get;
        }

        public decimal ISOValue
        {
            get;
        }

        public string Make
        {
            get;
        }
    }
}

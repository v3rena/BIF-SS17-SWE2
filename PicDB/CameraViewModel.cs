using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class CameraViewModel : ICameraViewModel
    {
		private ICameraModel mdl;

		public CameraViewModel()
        {

        }

		public CameraViewModel(ICameraModel mdl)
		{
			this.mdl = mdl;
		}

		public CameraViewModel(CameraModel cmdl)
        {
            BoughtOn = cmdl.BoughtOn;
            ID = cmdl.ID;
            Producer = cmdl.Producer;
            Make = cmdl.Make;
        }
        public DateTime? BoughtOn
        {
            get; set;
        }

        public int ID
        {
            get;
        }

        public decimal ISOLimitAcceptable
        {
            get; set;
        }

        public decimal ISOLimitGood
        {
            get; set;
        }

        public bool IsValid
        {
            get;
        }

        public bool IsValidBoughtOn
        {
            get;
        }

        public bool IsValidMake
        {
            get;
        }

        public bool IsValidProducer
        {
            get;
        }

        public string Make
        {
            get; set;
        }

        public string Notes
        {
            get; set;
        }

        public int NumberOfPictures
        {
            get;
        }

        public string Producer
        {
            get; set;
        }

        public string ValidationSummary
        {
            get;
        }

        public ISORatings TranslateISORating(decimal iso)
        {
            throw new NotImplementedException();
        }
    }
}

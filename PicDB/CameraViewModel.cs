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
			get
			{
				if (IsValidBoughtOn && IsValidMake && IsValidProducer)
				{
					return true;
				}
				else
				{
					return false;
				}
				
			}
		}

        public bool IsValidBoughtOn
        {
			get
			{
				if (this.BoughtOn != null && this.BoughtOn > DateTime.Now)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}

        public bool IsValidMake
        {
			get
			{
				if (string.IsNullOrEmpty(Make) || string.IsNullOrWhiteSpace(Make))
				{
					return false;
				}
				else
				{
					return true;
				}
			}
		}

        public bool IsValidProducer
        {
			get
			{
				if (string.IsNullOrEmpty(Producer) || string.IsNullOrWhiteSpace(Producer))
				{
					return false;
				}
				else
				{
					return true;
				}
			}
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
			get
			{
				string ValidationSummary = "";

				if (!IsValid)
				{
					if (!IsValidProducer)
					{
						ValidationSummary += "Producer cannot be null, empty or whitespace ";
					}
					if (!IsValidMake)
					{
						ValidationSummary += "Make cannot be null, empty or whitespace ";
					}
					if (!IsValidBoughtOn)
					{
						ValidationSummary += "Purchase date cannot be a future date";
					}
				}
				return ValidationSummary;
			}
		}

        public ISORatings TranslateISORating(decimal iso)
        {
            throw new NotImplementedException();
        }
    }
}

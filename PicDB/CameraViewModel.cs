﻿using System;
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
		private ICameraModel cmdl;

		public CameraViewModel()
        {

        }

		public CameraViewModel(ICameraModel mdl)
        {
            this.cmdl = mdl;
            /*
            BoughtOn = cmdl.BoughtOn;
            ID = cmdl.ID;
            Producer = cmdl.Producer;
            Make = cmdl.Make;
            ISOLimitGood = cmdl.ISOLimitGood;
            ISOLimitAcceptable = cmdl.ISOLimitAcceptable;*/
        }

		public DateTime? BoughtOn
        {
            get
            {
                return cmdl.BoughtOn;
            }
            set
            {
                cmdl.BoughtOn = value;
            }
        }

        public int ID
        {
            get
            {
                return cmdl.ID;
            }
        }

        public decimal ISOLimitAcceptable
        {
            get
            {
                return cmdl.ISOLimitAcceptable;
            }
            set
            {
                cmdl.ISOLimitAcceptable = value;
            }
        }

        public decimal ISOLimitGood
        {
            get
            {
                return cmdl.ISOLimitGood;
            }
            set
            {
                cmdl.ISOLimitGood = value;
            }
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
				if (string.IsNullOrEmpty(cmdl.Producer) || string.IsNullOrWhiteSpace(cmdl.Producer))
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
            get
            {
                return cmdl.Make;
            }
            set
            {
                cmdl.Make = value;
            }
        }

        public string Notes
        {
            get
            {
                return cmdl.Make;
            }
            set
            {
                cmdl.Make = value;
            }
        }

        public int NumberOfPictures
        {
            get;
        }

        public string Producer
        {
            get
            {
                return cmdl.Producer;
            }
            set
            {
                cmdl.Producer = value;
            }
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

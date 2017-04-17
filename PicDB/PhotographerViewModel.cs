using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class PhotographerViewModel : IPhotographerViewModel
    {
		public PhotographerViewModel()
		{

		}

		public PhotographerViewModel(IPhotographerModel mdl)
		{
			pmdl = mdl;
		}

		public DateTime? BirthDay
        {
            get
            {
                return pmdl.BirthDay;
            }

            set
            {
                pmdl.BirthDay = value;
                //OnNotifyPropertyChange - notify views of change!!
            }
        }

        public string FirstName
        {
            get
            {
                return pmdl.FirstName;
            }
            set
            {
                pmdl.FirstName = value;
            }
        }

        public int ID
        {
            get
            {
                return pmdl.ID;
            }
        }

        public bool IsValid
        {
            get
            {
                return IsValidBirthDay && IsValidLastName;
            }
        }

        public bool IsValidBirthDay
        {
            get
            {
                if(!pmdl.BirthDay.HasValue || pmdl.BirthDay < DateTime.Today)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                //return !photographer.Birthday.HasValue || photographer.Birthday < DateTime.Today;
            }
        }

        public bool IsValidLastName
        {
            get
            {
                if(String.IsNullOrWhiteSpace(LastName))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public string LastName
        {
            get
            {
                return pmdl.LastName;
            }
            set
            {
                pmdl.LastName = value;
            }
        }

        public string Notes
        {
            get
            {
                return pmdl.Notes;
            }
            set
            {
                pmdl.Notes = value;
            }
        }

        public int NumberOfPictures
        {
            get;
        }

        public string ValidationSummary
        {
            get
            {
                if(IsValid)
                {
                    return "";
                }
                else
                {
                    return "Photographer ViewModel is not valid";
                }
            }
        }

        private IPhotographerModel pmdl;
    }
}

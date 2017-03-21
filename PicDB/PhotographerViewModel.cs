using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class PhotographerViewModel : IPhotographerViewModel
    {
        public DateTime? BirthDay
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                //if(photographerBirthday!=value)
                //{photographerBirthday=value}
                //OnNotifyPropertyChange - notify views of change!!
                throw new NotImplementedException();
            }
        }

        public string FirstName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
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

        public bool IsValid
        {
            get
            {
                //return IsValidBirthDay && IsValidLastName;
                throw new NotImplementedException();
            }
        }

        public bool IsValidBirthDay
        {
            get
            {
                //return !photographer.Birthday.HasValue || photographer.Birthday < DateTime.Today;
                throw new NotImplementedException();
            }
        }

        public bool IsValidLastName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string LastName
        {
            get
            {
                //return string.IsNullOrWhiteSpace(photographer.LastName);
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Notes
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int NumberOfPictures
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string ValidationSummary
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}

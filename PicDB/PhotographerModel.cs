using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    class PhotographerModel : IPhotographerModel
    {
        public DateTime? BirthDay
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public string Notes
        {
            get; set;
        }
    }
}

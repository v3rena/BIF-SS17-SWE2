using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    class CameraModel : ICameraModel
    {
        public CameraModel()
        {

		}

        public CameraModel(string producer, string make)
        {
            Producer = producer;
            Make = make;
        }
        public DateTime? BoughtOn
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }

        public decimal ISOLimitAcceptable
        {
            get; set;
        }

        public decimal ISOLimitGood
        {
            get; set;
        }

        public string Make
        {
            get; set;
        }

        public string Notes
        {
            get; set;
        }

        public string Producer
        {
            get; set;
        }
    }
}

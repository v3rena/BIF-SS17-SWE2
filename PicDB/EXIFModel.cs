using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    class EXIFModel : IEXIFModel
    {
        public EXIFModel()
        {
            //mockdata
            ExposureProgram = ExposurePrograms.NotDefined;
            ExposureTime = 0;
            Flash = false;
            FNumber = 0;
            ISOValue = 0;
            Make = "test";
        }
        public ExposurePrograms ExposureProgram
        {
            get; set;
        }

        public decimal ExposureTime
        {
            get; set;
        }

        public bool Flash
        {
            get; set;
        }

        public decimal FNumber
        {
            get; set;
        }

        public decimal ISOValue
        {
            get; set;
        }

        public string Make
        {
            get; set;
        }
    }
}

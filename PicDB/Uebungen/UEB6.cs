﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using PicDB;

namespace Uebungen
{
    public class UEB6 : IUEB6
    {
        public void HelloWorld()
        {
        }

        public IBusinessLayer GetBusinessLayer()
        {
			var BL = new BusinessLayer(true);
			return BL;
		}

        public void TestSetup(string picturePath)
        {
            //throw new NotImplementedException();
        }

        public IPictureModel GetEmptyPictureModel()
        {
			return new PictureModel();
        }

        public IPhotographerModel GetEmptyPhotographerModel()
        {
			return new PhotographerModel();
        }
    }
}

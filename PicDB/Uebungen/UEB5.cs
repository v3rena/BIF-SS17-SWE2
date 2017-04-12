using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB;

namespace Uebungen
{
    public class UEB5 : IUEB5
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

        public IPhotographerModel GetEmptyPhotographerModel()
        {
			return new PhotographerModel();
        }

        public IPhotographerViewModel GetPhotographerViewModel(IPhotographerModel mdl)
        {
			return new PhotographerViewModel(mdl);
        }

        public ICameraModel GetEmptyCameraModel()
        {
			return new CameraModel();
        }

        public ICameraViewModel GetCameraViewModel(ICameraModel mdl)
        {
			return new CameraViewModel();
        }
    }
}

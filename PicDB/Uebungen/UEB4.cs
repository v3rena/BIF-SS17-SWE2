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
    public class UEB4 : IUEB4
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

        public IEXIFModel GetEmptyEXIFModel()
        {
			return new EXIFModel();
        }

        public IEXIFViewModel GetEXIFViewModel(IEXIFModel mdl)
        {
			return new EXIFViewModel((EXIFModel)mdl);
        }

        public IIPTCModel GetEmptyIPTCModel()
        {
			return new IPTCModel();
        }

        public IIPTCViewModel GetIPTCViewModel(IIPTCModel mdl)
        {
			return new IPTCViewModel((IPTCModel)mdl);
        }

        public ICameraModel GetCameraModel(string producer, string make)
        {
			return new CameraModel(producer, make);
		}

        public ICameraViewModel GetCameraViewModel(ICameraModel mdl)
        {
			return new CameraViewModel(mdl);
		}
    }
}

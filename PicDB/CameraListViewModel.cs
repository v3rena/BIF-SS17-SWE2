using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class CameraListViewModel : ICameraListViewModel
    {
        public ICameraViewModel CurrentCamera
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<ICameraViewModel> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}

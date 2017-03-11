using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class MainWindowViewModel : IMainWindowViewModel
    {
        public IPictureViewModel CurrentPicture
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IPictureListViewModel List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ISearchViewModel Search
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}

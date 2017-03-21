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
                return new PictureViewModel();
            }
        }

        public IPictureListViewModel List
        {
            get
            {
                return new PictureListViewModel();
            }
        }

        public ISearchViewModel Search
        {
            get
            {
                return new SearchViewModel();
            }
        }
    }
}

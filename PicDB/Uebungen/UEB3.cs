using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.ViewModels;
using PicDB;

namespace Uebungen
{
    public class UEB3 : IUEB3
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

        public IDataAccessLayer GetDataAccessLayer()
        {
            return new MockDAL();
        }

        public ISearchViewModel GetSearchViewModel()
        {
            return new SearchViewModel();
        }
    }
}

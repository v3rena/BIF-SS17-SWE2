﻿using System;
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
            return new BusinessLayer();
        }

        public void TestSetup(string picturePath)
        {
            //throw new NotImplementedException();
        }

        public IDataAccessLayer GetDataAccessLayer()
        {
            return new DataAccessLayer();
        }

        public ISearchViewModel GetSearchViewModel()
        {
            return new SearchViewModel();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class SearchViewModel : ISearchViewModel
    {
        public bool IsActive
        {
            get
            {
                return !string.IsNullOrWhiteSpace(SearchText);
            }
        }

        public int ResultCount
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string SearchText { get; set; }
    }
}

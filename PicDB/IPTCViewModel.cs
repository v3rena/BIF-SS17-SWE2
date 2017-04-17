using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.ViewModels;

namespace PicDB
{
    class IPTCViewModel : IIPTCViewModel
    {
        public IPTCViewModel()
        { }

        public IPTCViewModel(IPTCModel imdl)
        {
            ByLine = imdl.ByLine;
            Caption = imdl.Caption;
            CopyrightNotice = imdl.CopyrightNotice;
            Headline = imdl.Headline;
            Keywords = imdl.Keywords;
        }

        public string ByLine
        {
            get; set;
        }

        public string Caption
        {
            get; set;
        }

        public string CopyrightNotice
        {
            get; set;
        }

        public IEnumerable<string> CopyrightNotices
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Headline
        {
            get; set;
        }

        public string Keywords
        {
            get; set;
        }
    }
}

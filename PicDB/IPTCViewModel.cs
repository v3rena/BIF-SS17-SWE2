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

        public IPTCViewModel(IPTCModel mdl)
        {
            imdl = mdl;
            //, , , , , CC - BY - NC - SA, CC - BY - NC - ND
            notices.Add("All rights reserved");
            notices.Add("CC - BY");
            notices.Add("CC - BY - SA");
            notices.Add("CC - BY - ND");
            notices.Add("CC - BY - NC");
            notices.Add("CC - BY - NC - SA");
            notices.Add("CC - BY - NC - ND");
            /*
            ByLine = imdl.ByLine;
            Caption = imdl.Caption;
            CopyrightNotice = imdl.CopyrightNotice;
            Headline = imdl.Headline;
            Keywords = imdl.Keywords;*/
        }

        public string ByLine
        {
            get
            {
                return imdl.ByLine;
            }
            set
            {
                imdl.ByLine = value;
            }
        }

        public string Caption
        {
            get
            {
                return imdl.Caption;
            }
            set
            {
                imdl.Caption = value;
            }
        }

        public string CopyrightNotice
        {
            get
            {
                return imdl.CopyrightNotice;
            }
            set
            {
                imdl.CopyrightNotice = value;
            }
        }

        public IEnumerable<string> CopyrightNotices
        {
            get
            {
                return notices;
            }
        }

        public string Headline
        {
            get
            {
                return imdl.Headline;
            }
            set
            {
                imdl.Headline = value;
            }
        }

        public string Keywords
        {
            get
            {
                return imdl.Keywords;
            }
            set
            {
                imdl.Keywords = value;
            }
        }
        private IPTCModel imdl;
        private List<string> notices = new List<string>();
    }
}

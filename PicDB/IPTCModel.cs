﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    class IPTCModel : IIPTCModel
    {
		private IIPTCModel mdl;

		public IPTCModel()
        {
            //mockdata
            ByLine = "test";
            Caption = "test";
            CopyrightNotice = "test";
            Headline = "test";
            Keywords = "test";
        }

		public IPTCModel(IIPTCModel mdl)
		{
			this.mdl = mdl;
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

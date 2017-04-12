﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces.Models;

namespace PicDB
{
    class PictureModel : IPictureModel
    {
		CameraModel camera;

		public PictureModel()
        { }
        public PictureModel(string file)
        {
            this.FileName = file;
            this.EXIF = new EXIFModel();
            this.IPTC = new IPTCModel();
        }
        public ICameraModel Camera
        {
			get
			{
				return camera;
			}

			set
			{
				camera = (CameraModel)value;
			}
		}

        public IEXIFModel EXIF
        {
            get; set;
        }

        public string FileName
        {
            get; set;
        }

        public int ID
        {
            get; set;
        }

        public IIPTCModel IPTC
        {
            get; set;
        }
    }
}

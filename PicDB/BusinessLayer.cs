using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using System.IO;
using System.Windows.Media.Imaging;

namespace PicDB
{
    class BusinessLayer : IBusinessLayer
    {
        public BusinessLayer()
        {
            DAL = new DataAccessLayer();
        }

        public BusinessLayer(bool isTest)
        {
            DAL = new MockDAL();
        }
        public void DeletePhotographer(int ID)
        {
            throw new NotImplementedException();
        }

        public void DeletePicture(int ID)
        {
            throw new NotImplementedException();
        }

		//TODO: Anpassen für Datenbank
        public IEXIFModel ExtractEXIF(string filename)
        {
			MockDAL dalMock = new MockDAL();
			return dalMock.GetPicture(filename).EXIF;
		}

        public IIPTCModel ExtractIPTC(string filename)
        {
            var pic = DAL.GetPictures(filename, null, null, null);

            if(pic.Count() > 0)
            {
                string filepath = Directory.GetCurrentDirectory();
                filepath += "\\Pictures\\" + filename;
                if(File.Exists(filepath))
                {
                    var stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                    var decoder = new JpegBitmapDecoder(stream, BitmapCreateOptions.None, BitmapCacheOption.None);
                    var metadata = decoder.Frames[0].Metadata as BitmapMetadata;
                    if (metadata != null)
                    {
                        var IPTC = new IPTCModel();
                        if(metadata.Author != null)
                            IPTC.ByLine = metadata.Author.ToString();
                        if (metadata.Title != null)
                            IPTC.Headline = metadata.Title;
                        if (metadata.Subject != null)
                            IPTC.Caption = metadata.Subject;
                        if (metadata.Copyright != null)
                            IPTC.CopyrightNotice = metadata.Copyright;
                        if (metadata.Keywords != null)
                            IPTC.Keywords = metadata.Keywords.ToString();

						stream.Close();
						return IPTC;
                    }
                    else
                    {
                        throw new FileFormatException();
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public ICameraModel GetCamera(int ID)
        {
            return DAL.GetCamera(ID);
        }

        public IEnumerable<ICameraModel> GetCameras()
        {
            return DAL.GetCameras();
        }

        public IPhotographerModel GetPhotographer(int ID)
        {
            return DAL.GetPhotographer(ID);
        }

        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            return DAL.GetPhotographers();
        }

        public IPictureModel GetPicture(int ID)
        {
            return DAL.GetPicture(ID);
        }

        public IEnumerable<IPictureModel> GetPictures()
        {
            return Pictures;
        }

        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            return DAL.GetPictures(namePart, photographerParts, iptcParts, exifParts);
        }

        public void Save(IPhotographerModel photographer)
        {
            DAL.Save(photographer);
        }

        public void Save(IPictureModel picture)
        {
            DAL.Save(picture);
        }

        public void Sync()
        {
            string[] fileEntries = Directory.GetFiles(".\\Pictures");
            foreach (string fileName in fileEntries)
            {
                Pictures.Add(new PictureModel(fileName));
            }
        }

        public void WriteIPTC(string filename, IIPTCModel iptc)
        {
            throw new NotImplementedException();
        }

        private List<IPictureModel> Pictures = new List<IPictureModel>();

        private IDataAccessLayer DAL;
    }
}

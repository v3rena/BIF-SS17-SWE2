using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using System.IO;

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
            throw new NotImplementedException();
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

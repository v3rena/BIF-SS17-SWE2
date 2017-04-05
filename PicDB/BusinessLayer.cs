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

        public IEXIFModel ExtractEXIF(string filename)
        {
            throw new NotImplementedException();
        }

        public IIPTCModel ExtractIPTC(string filename)
        {
            throw new NotImplementedException();
        }

        public ICameraModel GetCamera(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICameraModel> GetCameras()
        {
            return Cameras;
        }

        public IPhotographerModel GetPhotographer(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            return Photographers;
        }

        public IPictureModel GetPicture(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPictureModel> GetPictures()
        {
            return Pictures;
        }

        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            throw new NotImplementedException();
        }

        public void Save(IPhotographerModel photographer)
        {
            throw new NotImplementedException();
        }

        public void Save(IPictureModel picture)
        {
            throw new NotImplementedException();
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

        private List<IPhotographerModel> Photographers = new List<IPhotographerModel>();

        private List<ICameraModel> Cameras = new List<ICameraModel>();

        private IDataAccessLayer DAL;
    }
}

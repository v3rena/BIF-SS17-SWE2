using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using BIF.SWE2.Interfaces.Models;
using System.IO;

namespace PicDB
{
    class MockDAL : IDataAccessLayer
    {
        public MockDAL()
        {
            //Fake Pictures
            FakePictures.Add(new PictureModel());
            FakePictures.Add(new PictureModel());
            FakePictures.Add(new PictureModel());
            FakePictures[0].ID = 1234;
            
            //Fake Photographers
            FakePhotographers.Add(new PhotographerModel());
            FakePhotographers.Add(new PhotographerModel());
            FakePhotographers.Add(new PhotographerModel());
            FakePhotographers[0].ID = 1234;
            
            //Fake Cameras
            FakeCameras.Add(new CameraModel());
            FakeCameras.Add(new CameraModel());
            FakeCameras.Add(new CameraModel());
            FakeCameras[0].ID = 1234;
        }
        public void DeletePhotographer(int ID)
        {
            for(int i = 0; i < FakePhotographers.Count; i++)
            {
                if(FakePhotographers[i].ID == ID)
                {
                    FakePhotographers.RemoveAt(i);
                    i--;
                }
            }
        }

        public void DeletePicture(int ID)
        {
            for (int i = 0; i < FakePictures.Count; i++)
            {
                if (FakePictures[i].ID == ID)
                {
                    FakePictures.RemoveAt(i);
                    i--;
                }
            }
        }

        public ICameraModel GetCamera(int ID)
        {
            foreach (var cam in FakeCameras)
            {
                if (cam.ID == ID)
                {
                    return cam;
                }
            }

            return null;
        }

        public IEnumerable<ICameraModel> GetCameras()
        {
            return FakeCameras;
        }

        public IPhotographerModel GetPhotographer(int ID)
        {
            foreach (var phot in FakePhotographers)
            {
                if (phot.ID == ID)
                {
                    return phot;
                }
            }

            return null;
        }

        public IEnumerable<IPhotographerModel> GetPhotographers()
        {
            return FakePhotographers;
        }

        public IPictureModel GetPicture(int ID)
        {
            foreach(var pic in FakePictures)
            {
                if(pic.ID == ID)
                {
                    return pic;
                }
            }

            return null;            
        }

        public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            return FakePictures;
        }

        public void Save(IPhotographerModel photographer)
        {
            throw new NotImplementedException();
        }

        public void Save(IPictureModel picture)
        {
            throw new NotImplementedException();
        }

        private List<IPictureModel> FakePictures = new List<IPictureModel>();
        private List<ICameraModel> FakeCameras = new List<ICameraModel>();
        private List<IPhotographerModel> FakePhotographers = new List<IPhotographerModel>();
    }
}

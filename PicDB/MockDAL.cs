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
            FakePictures[0].FileName = "Blume.jpg";
            FakePictures[1].ID = 2;
            FakePictures[2].ID = 3;

            //Fake Photographers
            FakePhotographers.Add(new PhotographerModel());
            FakePhotographers.Add(new PhotographerModel());
            FakePhotographers.Add(new PhotographerModel());
            FakePhotographers[0].ID = 1234;
            FakePhotographers[1].ID = 2;
            FakePhotographers[2].ID = 3;

            //Fake Cameras
            FakeCameras.Add(new CameraModel());
            FakeCameras.Add(new CameraModel());
            FakeCameras.Add(new CameraModel());
            FakeCameras[0].ID = 1234;
            FakeCameras[1].ID = 2;
            FakeCameras[2].ID = 3;

            //Fake EXIF
            EXIFModel exmdl = new EXIFModel();
			exmdl.ExposureProgram = ExposurePrograms.Manual;
			exmdl.ExposureTime = 1000;
			exmdl.Flash = false;
			exmdl.FNumber = 10;
			exmdl.ISOValue = 200;
			exmdl.Make = "Blubb";

			FakePictures[1].FileName = "Img1.jpg";
			FakePictures[1].EXIF = exmdl;


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

		public IPictureModel GetPicture(string filename)
		{
			if (FakePictures != null && FakePictures.Count() > 0)
			{
				var res = FakePictures.Where(x => x.FileName == filename);
				if (res.Count() > 0)
				{
					return res.First();
				}
			}
			return null;
		}


		public IEnumerable<IPictureModel> GetPictures(string namePart, IPhotographerModel photographerParts, IIPTCModel iptcParts, IEXIFModel exifParts)
        {
            if(namePart == null && photographerParts == null && iptcParts == null && exifParts == null)
            {
                return FakePictures;
            }
            List<IPictureModel> elements = new List<IPictureModel>();
            foreach(var pic in FakePictures)
            {
                if(pic.FileName != null)
                {
                    bool contains = pic.FileName.ToLower().Contains(namePart.ToLower());
                    if (contains)
                    {
                        elements.Add(pic);
                    }
                }                
            }
            return elements;
        }

        public void Save(IPhotographerModel photographer)
        {
            FakePhotographers.Add(photographer);
            FakePhotographers.Last().ID = FakePhotographers[FakePhotographers.Count - 2].ID + 1;
        }

        public void Save(IPictureModel picture)
        {
            FakePictures.Add(picture);
            FakePictures.Last().ID = FakePictures[FakePictures.Count - 2].ID + 1;
        }

        private List<IPictureModel> FakePictures = new List<IPictureModel>();
        private List<ICameraModel> FakeCameras = new List<ICameraModel>();
        private List<IPhotographerModel> FakePhotographers = new List<IPhotographerModel>();
    }
}

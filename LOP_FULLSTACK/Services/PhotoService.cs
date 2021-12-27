using LOP_FULLSTACK.Models;

namespace LOP_FULLSTACK.Services
{
    public class PhotoService : IPhotoService
    {
        public List<Photo> GetPhotos()
        {
            return new List<Photo>
            {
                new Photo()
                {
                    CreatedDate = DateTime.Now,
                    Description = "Desciption 1",
                    Owner = 1,
                    PhotoFile = "https://placeimg.com/640/480/animals/grayscale",
                    PhotoId =   1,
                    Title = "Photo1"
                },
                new Photo()
                {
                    CreatedDate = DateTime.Now,
                    Description = "Desciption 1",
                    Owner = 1,
                    PhotoFile = "https://placeimg.com/640/480/animals/grayscale",
                    PhotoId =   2,
                    Title = "Photo2"
                },
                new Photo()
                {
                    CreatedDate = DateTime.Now,
                    Description = "Desciption 1",
                    Owner = 1,
                    PhotoFile = "https://placeimg.com/640/480/animals/grayscale",
                    PhotoId =   3,
                    Title = "Photo3"
                }
            };
        }
    }
}

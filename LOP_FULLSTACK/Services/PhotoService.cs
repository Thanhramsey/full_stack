using LOP_FULLSTACK.Models;

namespace LOP_FULLSTACK.Services
{
    public class PhotoService : IPhotoService
    {

        private readonly PhotoContext  _context;

        public PhotoService (PhotoContext context)
        {
            _context= context;
        }
        public IQueryable<Photo> Photos => _context.Photos;

        public IQueryable<Comment> Comments => _context.Comments;

        public void Add(Photo photo)
        {
            var photos = _context.Photos.ToList();
            photos.Add(photo);
            _context.Photos = photos.AsQueryable();
        }

        public void Add(Comment comment)
        {
            var comments = _context.Comments.ToList();
            comments.Add(comment);
            _context.Comments = comments.AsQueryable();
        }

        public void Delete(Photo photo)
        {
            var photos = _context.Photos.ToList();
            var item = _context.Photos.FirstOrDefault(x=>x.PhotoId == photo.PhotoId);

            if(item != null)
            {
                photos.Remove(item);
                _context.Photos = photos.AsQueryable();
            }
        }

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

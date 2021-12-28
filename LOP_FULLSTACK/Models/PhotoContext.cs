namespace LOP_FULLSTACK.Models
{
    public class PhotoContext
    {
        public IQueryable<Photo> Photos = new List<Photo>()
        {
            new Photo()
            {
                PhotoId = 1,
                CreatedDate = DateTime.Now,
                Description = "Photo 1",
                Owner = 1,
                PhotoFile = "https://placeimg.com/640/480/any",
                Title = "Photo 1"
            },
            new Photo()
            {
                PhotoId = 2,
                CreatedDate = DateTime.Now,
                Description = "Photo 2",
                Owner = 1,
                PhotoFile = "https://placeimg.com/320/240/any",
                Title = "Photo 2"
            },
            new Photo()
            {
                PhotoId = 3,
                CreatedDate = DateTime.Now,
                Description = "Photo 3",
                Owner = 1,
                PhotoFile = "https://placeimg.com/400/300/any",
                Title = "Photo 3"
            },
            new Photo()
            {
                PhotoId = 4,
                CreatedDate = DateTime.Now,
                Description = "Photo 4",
                Owner = 1,
                PhotoFile = "https://placeimg.com/410/320/any",
                Title = "Photo 4"
            },
            new Photo()
            {
                PhotoId = 5,
                CreatedDate = DateTime.Now,
                Description = "Photo 5",
                Owner = 1,
                PhotoFile = "https://placeimg.com/460/380/any",
                Title = "Photo 5"
            }
        }.AsQueryable();

        public IQueryable<Comment> Comments = new List<Comment>()
        {
            new Comment()
            {
                CommentId = 1,
                Body = "Amazing, Good Job",
                Subject = "Nice!!!",
                PhotoId = 1,
                User = "Vuong Nguyen"
            },
            new Comment()
            {
                CommentId = 2,
                Body = "Amazing, Good Job",
                Subject = "Nice!!!",
                PhotoId = 2,
                User = "Vuong Nguyen"
            },
            new Comment()
            {
                CommentId = 3,
                Body = "Amazing, Good Job",
                Subject = "Nice!!!",
                PhotoId = 3,
                User = "Vuong Nguyen"
            },
            new Comment()
            {
                CommentId = 4,
                Body = "Amazing, Good Job",
                Subject = "Nice!!!",
                PhotoId = 4,
                User = "Vuong Nguyen"
            },
            new Comment()
            {
                CommentId = 5,
                Body = "Amazing, Good Job",
                Subject = "Nice!!!",
                PhotoId = 5,
                User = "Vuong Nguyen"
            },
            new Comment()
            {
                CommentId = 6,
                Body = "Amazing, Good Job",
                Subject = "Nice!!!",
                PhotoId = 1,
                User = "Vuong Nguyen"
            },
            new Comment()
            {
                CommentId = 7,
                Body = "Amazing, Good Job",
                Subject = "Nice!!!",
                PhotoId = 2,
                User = "Vuong Nguyen"
            },
            new Comment()
            {
                CommentId = 8,
                Body = "Amazing, Good Job",
                Subject = "Nice!!!",
                PhotoId = 3,
                User = "Vuong Nguyen"
            },
            new Comment()
            {
                CommentId = 9,
                Body = "Amazing, Good Job",
                Subject = "Nice!!!",
                PhotoId = 3,
                User = "Vuong Nguyen"
            }
        }.AsQueryable();
    }

}

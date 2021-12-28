using LOP_FULLSTACK.Models;
using System.Linq;

namespace LOP_FULLSTACK.Services
{
    public interface IPhotoService
    {
        List<Photo> GetPhotos();

        IQueryable<Photo> Photos { get; }

        void Add(Photo photo);
        void Delete(Photo photo);

        IQueryable<Comment> Comments { get; }

        void Add(Comment comment);
    }

    
}

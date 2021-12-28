using LOP_FULLSTACK.Services;
using Microsoft.AspNetCore.Mvc;

namespace LOP_FULLSTACK.ViewComponents
{
    public class DisplayCommentsViewComponent :ViewComponent
    {
        private readonly IPhotoService _photoService;

        // inhect service
        public DisplayCommentsViewComponent(IPhotoService photoService)
        {
            _photoService = photoService;
        }
        //public async Task<IViewComponentResult> InvokeAsync(int photoId)
        public IViewComponentResult Invoke(int photoId)
        {
            ViewBag.PhotoId = photoId;

            var comments = _photoService.Comments.Where(x => x.PhotoId == photoId).ToList();
            return View(comments);
        }

    }
}

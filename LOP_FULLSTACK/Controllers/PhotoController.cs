using LOP_FULLSTACK.Models;
using LOP_FULLSTACK.Services;
using Microsoft.AspNetCore.Mvc;

namespace LOP_FULLSTACK.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DisplayGallery()
        {
            var model = _photoService.Photos.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult DisplayRecent()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DisplayPhoto(int id)
        {
            var photo = _photoService.Photos.FirstOrDefault(item=> item.PhotoId == id);
            if(photo == null)
            {
                return NotFound();
            }
            return View(photo);
        }

        [HttpGet]
        public IActionResult AddPhoto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPhoto(Photo Model)
        {
            return RedirectToAction(nameof(DisplayGallery));
        }

        public IActionResult DeletePhoto(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DeletePhoto(Photo Model)
        {
            return RedirectToAction(nameof(DisplayGallery));
        }

    }
}

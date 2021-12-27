using LOP_FULLSTACK.Models;
using Microsoft.AspNetCore.Mvc;

namespace LOP_FULLSTACK.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult AddComment(int Id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult DisplayComments()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddComment(int id, Comment comment)
        {
            return Redirect(Url.Action("DisplayPhoto", "Photo", new { id = id }));

        }
    }
}

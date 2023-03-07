using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc_Blog.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}

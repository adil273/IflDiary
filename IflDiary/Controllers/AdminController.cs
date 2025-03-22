using Microsoft.AspNetCore.Mvc;

namespace IflDiary.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

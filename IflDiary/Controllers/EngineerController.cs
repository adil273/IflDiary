using Microsoft.AspNetCore.Mvc;

namespace IflDiary.Controllers
{
    public class EngineerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

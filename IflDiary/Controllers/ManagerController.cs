using Microsoft.AspNetCore.Mvc;

namespace IflDiary.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using IflDiary.Models;
using Microsoft.AspNetCore.Mvc;

namespace IflDiary.Controllers
{
    public class EngineerController : Controller
    {
        private IflDiaryContext _context;
        public EngineerController(IflDiaryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        ///DEMAND CRUD STARS HERE//////////////////////////////////////
        public IActionResult Demands()
        {
            List<Demand> demand = _context.Demands.ToList();
            return View(demand);
        }
        [HttpGet]
        public IActionResult AddUpdateDemand(int id=0)
        {
            if (id == 0)
            {
                return View();
            }
            else 
            { 
                Demand demand = _context.Demands.Where(x => x.Id == id).FirstOrDefault();
                return View(demand);
            }
            
            
        }
        [HttpPost]
        public IActionResult AddUpdateDemand(Demand demand)
        {
            _context.Demands.Update(demand);
            _context.SaveChanges();
            return Redirect("/Engineer/Demands");
            
        }
        [HttpGet]
        public IActionResult DeleteDemand(int id)
        {
            Demand demand = _context.Demands.Where(x => x.Id == id).FirstOrDefault();
            _context.Demands.Remove(demand);
            _context.SaveChanges();
            return Redirect("/Engineer/Demands");
        }
        ///DEMAND CRUD ENDS HERE//////////////////////////////////////
    }
}

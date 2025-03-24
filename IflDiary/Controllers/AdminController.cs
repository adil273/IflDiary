using System.Data;
using IflDiary.Models;
using Microsoft.AspNetCore.Mvc;

namespace IflDiary.Controllers
{
    public class AdminController : Controller
    {
        private IflDiaryContext _context;
        public AdminController(IflDiaryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        ///////////ROLE CRUS STARTS HERE////////////////////
        public IActionResult Roles()
        {
            List<Role> role = _context.Roles.ToList();
            return View(role);
        }
        [HttpGet]
        public IActionResult AddUpdateRole(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                Role role = _context.Roles.Where(x => x.Id == id).FirstOrDefault();
                return View(role);
            }

        }
        [HttpPost]
        public IActionResult AddUpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
            return Redirect("/Admin/Roles");
        }
        [HttpGet]
        public IActionResult DeleteRole(int id)
        {
            Role role = _context.Roles.Where(x => x.Id == id).FirstOrDefault();
            _context.Roles.Remove(role);
            _context.SaveChanges();
            return Redirect("/Admin/Roles");
        }
        ///////////ROLE CRUS ENDS HERE////////////////////

        //////////////PURCHASE CRUS STARTS HERE////////////////////
        public IActionResult Purchasers()
        {
            List<Purchaser> purchaser = _context.Purchasers.ToList();
            return View(purchaser);
        }
        [HttpGet]
        public IActionResult AddUpdatePurchaser(int id=0)
        {
            if (id == 0)
            {
                return View();
            }
            else 
            {
                Purchaser purchaser = _context.Purchasers.Where(x => x.Id == id).FirstOrDefault();
                return View(purchaser);

            }
        }
        [HttpPost]
        public IActionResult AddUpdatePurchaser(Purchaser purchaser)
        {
            _context.Purchasers.Update(purchaser);
            _context.SaveChanges();
            return Redirect("/Admin/Purchasers");
        }
        [HttpGet]
        public IActionResult DeletePurchaser(int id)
        {
            Purchaser purchaser = _context.Purchasers.Where(x => x.Id == id).FirstOrDefault();
            _context.Purchasers.Remove(purchaser);
            _context.SaveChanges();
            return Redirect("/Admin/Purchasers");
        }


        //////////////PURCHASE CRUS ENDS HERE////////////////////




    }
}

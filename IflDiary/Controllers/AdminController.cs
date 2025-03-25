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
        //////////////DEMAND CATEGORY CRUD STARTS HERE////////////////////
        public IActionResult DemandCategories()
        {
            List<DemandCategory> DemandCategory = _context.DemandCategories.ToList();
            return View(DemandCategory);
        }
        [HttpGet]
        public IActionResult AddUpdateDemandCategory(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                DemandCategory DemandCategory = _context.DemandCategories.Where(x => x.Id == id).FirstOrDefault();
                return View(DemandCategory);

            }
        }
        [HttpPost]
        public IActionResult AddUpdateDemandCategory(DemandCategory DemandCategory)
        {
            _context.DemandCategories.Update(DemandCategory);
            _context.SaveChanges();
            return Redirect("/Admin/DemandCategories");
        }
        [HttpGet]
        public IActionResult DeleteDemandCategory(int id)
        {
            DemandCategory DemandCategory = _context.DemandCategories.Where(x => x.Id == id).FirstOrDefault();
            _context.DemandCategories.Remove(DemandCategory);
            _context.SaveChanges();
            return Redirect("/Admin/DemandCategories");
        }

        //////////////DEMAND CATEGORY CRUD ENDS HERE////////////////////

        //////////////DEMAND CATEGORY CRUD STARTS HERE////////////////////
        //////////////ELECTRICAL DEPARTMENT CRUD STARTS HERE////////////////////
        public IActionResult ElectricalDepartments()
        {
            List<ElectricalDepartment> ElectricalDepartment = _context.ElectricalDepartments.ToList();
            return View(ElectricalDepartment);
        }
        [HttpGet]
        public IActionResult AddUpdateElectricalDepartment(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                ElectricalDepartment ElectricalDepartment = _context.ElectricalDepartments.Where(x => x.Id == id).FirstOrDefault();
                return View(ElectricalDepartment);

            }
        }
        [HttpPost]
        public IActionResult AddUpdateElectricalDepartment(ElectricalDepartment ElectricalDepartment)
        {
            _context.ElectricalDepartments.Update(ElectricalDepartment);
            _context.SaveChanges();
            return Redirect("/Admin/ElectricalDepartments");
        }
        [HttpGet]
        public IActionResult DeleteElectricalDepartment(int id)
        {
            ElectricalDepartment ElectricalDepartment = _context.ElectricalDepartments.Where(x => x.Id == id).FirstOrDefault();
            _context.ElectricalDepartments.Remove(ElectricalDepartment);
            _context.SaveChanges();
            return Redirect("/Admin/ElectricalDepartments");
        }
        //////////////ELECTRICAL DEPARTMENTCRUD ENDS HERE////////////////////




    }
}

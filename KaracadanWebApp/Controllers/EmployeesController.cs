using KaracadanWebApp.Core.Domain;
using KaracadanWebApp.Data;
using KaracadanWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaracadanWebApp.Controllers
{
    [Authorize]
    public class EmployeesController : BaseController
    {
        public EmployeesController(UserManager<ApplicationUser> userManager, ApplicationDbContext _context, RoleManager<IdentityRole> roleManager) : base(userManager, null, _context, roleManager)
        {
        }

        public async Task<IActionResult> Index()
        {
            var allPersonels = await _context.Employees.ToListAsync();
            ViewBag.BreadCrumbFirstItem = "Employee";
            ViewBag.BreadCrumbSecondItem = "Employee List";
            return View(allPersonels);
        }


        public IActionResult Create()
        {
            var person = new Employee();
            ViewBag.BreadCrumbFirstItem = "Employee";
            ViewBag.BreadCrumbSecondItem = "Add New Employee";
            return View(person);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee personel)
        {
            await _context.Employees.AddAsync(personel);
            await _context.SaveChangesAsync();
            var allPersonels = await _context.Employees.ToListAsync();
            return View("Index", allPersonels);
        }
    }
}

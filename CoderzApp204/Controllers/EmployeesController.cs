using CoderzApp204.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoderzApp204.Controllers
{
    public class EmployeesController : Controller
    {
        private CoderZDbContext db;
        public EmployeesController(CoderZDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            var getEmployees = db.Employees.ToList();
            return View(getEmployees);
        }

    }
}

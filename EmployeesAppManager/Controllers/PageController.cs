using Microsoft.AspNetCore.Mvc;

namespace EmployeesAppManager.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

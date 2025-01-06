using EmployeesAppManager.Data;
using EmployeesAppManager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EmployeesAppManager.Controllers
{
    public class SignUpController : Controller
    {
        private readonly WebDbContext _context;

        // Constructor to inject the database context
        public SignUpController(WebDbContext context)
        {
            _context = context;
        }

        // GET: SignUp
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        // POST: SignUp
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp([Bind("Id,UserName,Email,Password")] SignUp user)
        {
            if (ModelState.IsValid)
            {
                // Hash the password before saving
                user.Password = HashPassword(user.Password);

                // Save the user to the database
                //_context.SignUps.Add(user);
                await _context.SaveChangesAsync();

                // Redirect to a "SignIn" action or confirmation page
                return RedirectToAction("SignIn", "SignIn");
            }

            // Return the same view if validation fxails
            return View(user);
        }

        // Hash password method (implement hashing logic here)
        private string HashPassword(string password)
        {
            // Placeholder: Replace with a real hashing implementation (e.g., BCrypt)
            return password; // For now, return the plain password (not recommended).
        }
    }
}

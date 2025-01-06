using EmployeesAppManager.Data;
using EmployeesAppManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EmployeesAppManager.Controllers
{
    public class SignInController : Controller
    {
        private readonly WebDbContext _context;

        // Constructor to inject the database context
        public SignInController(WebDbContext context)
        {
            _context = context;
        }

        // GET: SignIn
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        // POST: SignIn
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public Task<IActionResult> SignIn([Bind("UserName,Password")] SignIn model)
         public async Task<IActionResult> SignIn([Bind("UserName,Password")] SignIn model)

        {
            if (ModelState.IsValid)
            {
                // Retrieve user from the database based on username

                // Validate user credentials
                //var user = _context.SignUps.FirstOrDefault(u => u.UserName == model.UserName);
                var user = await _context.SignUps.FirstOrDefaultAsync(u => u.UserName == model.UserName);
                if (user != null && VerifyPassword(model.Password, user.Password))
                {
                    // Store user info in TempData or Session
                    TempData["UserName"] = user.UserName;

                    // Redirect to a dashboard or another page
                    //return Task.FromResult<IActionResult>(RedirectToAction("Index", "Home"));
                    return RedirectToAction("Index","Home");

                }

                // Add an error message for invalid credentials
                ModelState.AddModelError(string.Empty, "Invalid username or password.");
            }

            // Return the view with validation errors
            //return Task.FromResult<IActionResult>(View(model));
            //return View(model);
            return RedirectToAction("Index", "Home");

        }

        // Password verification method (implement proper logic here)
        private bool VerifyPassword(string enteredPassword, string storedPassword)
        {
            // Placeholder: Replace with proper password hashing verification
            return enteredPassword == storedPassword;
            //return BCrypt.Net.BCrypt.Verify(enteredPassword, storedPassword);
        }
    }
}

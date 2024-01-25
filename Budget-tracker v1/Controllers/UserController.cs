using Budget_tracker_v1.Data;
using Budget_tracker_v1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;


namespace Budget_tracker_v1.Controllers
{
    public class UserController : Controller
    {

        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        private bool CheckUserExists(string username)
        {
            return _context.Users.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        // Methods for user management
        public IActionResult Register()
        {
            // Show user registration form
            return View(new User());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            // Process user registration
            if (ModelState.IsValid)
            {
                // Check if user already exists
                if (CheckUserExists(user.Username))
                {
                    ModelState.AddModelError("", "Username already taken");
                    return View(user);
                }

                // Implement registration logic here
                var hasher = new PasswordHasher<User>();
                var hashedPassword = hasher.HashPassword(null, user.Password);

                var users = new User
                {
                    Username = user.Username,
                    Email = user.Email,
                    PasswordHash = hashedPassword
                };
                // Save user to the database
                _context.Users.Add(users);
                await _context.SaveChangesAsync();
                // Redirect to a different action/method upon successful registration
                return RedirectToAction("Index", "Home");
            }

            // If we got this far, something failed; redisplay the form
            return View(user);
        }


        public IActionResult Edit(int id)
        {
            // Show form to edit user details
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            // Process user details update
        }

        public IActionResult Details(int id)
        {
            // Show user details
        }

        // Other methods like Delete, ChangePassword, etc.
    }

}

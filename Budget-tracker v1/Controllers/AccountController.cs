using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using Budget_tracker_v1.Models;
namespace Budget_tracker_v1.Controllers
{
    public class AccountController : Controller
    {
        // Methods for account management
        public IActionResult Create()
        {
            // Show account creation form
        }

        [HttpPost]
        public IActionResult Create(Account account)
        {
            // Process account creation
        }

        public IActionResult Edit(int id)
        {
            // Show form to edit account
        }

        [HttpPost]
        public IActionResult Edit(Account account)
        {
            // Process account update
        }

        public IActionResult List()
        {
            // List all accounts
        }

        // Other methods like Delete, Details, etc.
    }

}

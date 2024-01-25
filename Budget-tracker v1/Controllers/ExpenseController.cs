using Microsoft.AspNetCore.Mvc;
using Budget_tracker_v1.Models;
namespace Budget_tracker_v1.Controllers
{
    public class ExpenseController : Controller
    {
        // Dependency injection of services/DB context
        public ExpenseController(/* Your services or DB context */)
        {
            // Initialize services/DB context
        }

        // GET: Expense
        public IActionResult Index()
        {
            // Retrieve list of expenses and return view
        }

        // GET: Expense/Create
        public IActionResult Create()
        {
            // Return the create expense view
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                // Save expense
                return RedirectToAction(nameof(Index));
            }
            return View(expense);
        }

        // Additional actions like Edit, Delete, Details, etc.
    }
}

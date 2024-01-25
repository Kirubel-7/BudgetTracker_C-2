using Microsoft.AspNetCore.Mvc;
using Budget_tracker_v1.Models;
namespace Budget_tracker_v1.Controllers
{
    public class TransactionController : Controller
    {
        // Methods for transaction management
        public IActionResult Create()
        {
            // Show transaction creation form
        }

        [HttpPost]
        public IActionResult Create(Transaction transaction)
        {
            // Process transaction creation
        }

        public IActionResult Edit(int id)
        {
            // Show form to edit transaction
        }

        [HttpPost]
        public IActionResult Edit(Transaction transaction)
        {
            // Process transaction update
        }

        public IActionResult List()
        {
            // List all transactions
        }

        // Other methods like Delete, Details, etc.
    }

}

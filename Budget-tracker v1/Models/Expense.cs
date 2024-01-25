namespace Budget_tracker_v1.Models
{
    public class Expense
    {
        public int Id { get; set; } // Primary key
        public string Category { get; set; } // Category of the expense
        public decimal Amount { get; set; } // Amount of the expense
        public DateTime Date { get; set; } // Date of the expense
        public string Description { get; set; } // Additional details about the expense

        // Other properties relevant to an expense can be added here
    }

}

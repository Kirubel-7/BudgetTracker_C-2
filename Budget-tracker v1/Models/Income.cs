namespace Budget_tracker_v1.Models
{
    public class Income
    {
        public int Id { get; set; }
        public string Source { get; set; } // Name or source of the income
        public decimal Amount { get; set; }
        public DateTime DateReceived { get; set; }
        // Other relevant properties, like Category, Frequency, etc.
    }

}

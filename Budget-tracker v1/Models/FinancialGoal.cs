namespace Budget_tracker_v1.Models
{
    public class FinancialGoal
    {
        public int Id { get; set; }
        public string Name { get; set; } // Name or title of the goal
        public decimal TargetAmount { get; set; }
        public DateTime TargetDate { get; set; }
        public decimal CurrentAmount { get; set; } // Current progress towards the goal
                                                   // Other relevant properties, like Status, Category, etc.
    }

}

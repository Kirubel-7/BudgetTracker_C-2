

using System.ComponentModel.DataAnnotations;

namespace Budget_tracker_v1.Models
{
    public class User
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]

        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        
        public DateTime createdAt { get; set; }
        public string PasswordHash { get; internal set; }

        public User()
        {
            createdAt = DateTime.UtcNow;
        }
    }
}

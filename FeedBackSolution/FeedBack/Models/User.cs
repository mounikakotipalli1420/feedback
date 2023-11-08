using System.ComponentModel.DataAnnotations;

namespace FeedbackGenerationApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } // Auto-generated primary key

        public string? Username { get; set; }
        public byte[]? Password { get; set; }
        public string? Role { get; set; }
        public byte[]? Key { get; set; }

    }
}

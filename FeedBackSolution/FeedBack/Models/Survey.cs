using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackGenerationApp.Models
{
    public class Survey
    {
        [Key]
        public int SurveyId { get; set; } // Primary Key

        public string? SurveyName { get; set; }
        public int TemplateId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Reference to Users table
        // public int CreatedByUserId { get; set; } // Foreign Key
        [Key]
        public User? CreatedBy { get; set; } // Navigation property to User

        // public int RoleId { get; set; } // Foreign Key
        [ForeignKey("Role")]
        public User? Role { get; set; } // Navigation property to User
    }
}
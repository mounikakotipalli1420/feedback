using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackGenerationApp.Models
{
    public class SurveyTemplate
    {
        [Key]
        public int TemplateId { get; set; } // Primary Key
        public string TemplateName { get; set; }
        public string TemplateDescription { get; set; }

        // Reference to the creator from the Survey class
        // public int CreatedByUserId { get; set; } // Foreign Key
        [ForeignKey("CreatedBY")]
        public Survey CreatedBy { get; set; } // Navigation property to User
    }


}
}
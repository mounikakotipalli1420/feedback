using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackGenerationApp.Models
{
    public class DistributionList
    {
        [Key]
        public int CustomerId { get; set; }//primary key
        public bool EmailOption { get; set; }
        public bool WhatsAppOption { get; set; }

        public string role { get; set; }//references userclass
        [ForeignKey("UserId")]
        public int UserId { get; set; }//references users table

    }
}
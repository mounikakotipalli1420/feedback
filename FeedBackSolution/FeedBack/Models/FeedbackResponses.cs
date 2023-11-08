using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FeedbackGenerationApp.Models


{
    public class FeedbackResponses
    {
        [Key]
        public int ResponseId { get; set; }//primary key
        [ForeignKey("QuestionId")]
        public int QuestionId { get; set; }//foreign key
        public string? ResponseText { get; set; }
        public string? Status { get; set; }
    }
}
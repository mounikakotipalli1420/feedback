using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackGenerationApp.Models
{
    public class CustomerResponses
    {
        public int CustomerResponseId { get; set; }
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }//foreign key
        [ForeignKey("QuestionId")]
        public int QuestionId { get; set; }//from questions table
        public string? CustomerResponse { get; set; }

    }
}
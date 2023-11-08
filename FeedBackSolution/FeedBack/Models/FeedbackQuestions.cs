using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackGenerationApp.Models
{
    public class FeedbackQuestions
    {
        [Key]
        public int QuestionId { get; set; } // Primary Key 
        public string? QuestionText { get; set; }
        public string? QuestionType { get; set; }
        public List<string>? Options { get; set; }
        [ForeignKey("SurveyId")]
        public int SurveyId { get; set; }
        //public Survey Survey { get; set; } // Navigation property to Survey

    }
}
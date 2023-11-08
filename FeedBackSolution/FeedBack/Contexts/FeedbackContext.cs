using Azure.Core;
using FeedbackGenerationApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace FeedbackGenerationApp.Contexts
{
    public class FeedbackContext : DbContext
    {
        public FeedbackContext(DbContextOptions<FeedbackContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyTemplate> SurveyTemplates { get; set; }
        public DbSet<FeedbackQuestions> FeedbackQuestions { get; set; }
        public DbSet<FeedbackResponses> FeedbackResponses { get; set; }
        public DbSet<DistributionList> DistributionLists { get; set; }
        public DbSet<CustomerResponses> CustomerResponses { get; set; }
        public DbSet<FeedbackSubmissions> FeedbackSubmissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships between entities using lambda expressions

            modelBuilder.Entity<Survey>()
                .HasOne(s => s.Template)
                .WithMany(t => t.Surveys)
                .HasForeignKey(s => s.TemplateId);

            modelBuilder.Entity<Survey>()
                .HasMany(s => s.Roles)
                .WithMany(u => u.SurveysWithRole)
                .UsingEntity<Dictionary<string, object>>(
                    "SurveyUserRoles",
                    j => j.HasOne<User>().WithMany().HasForeignKey("UserId"),
                    j => j.HasOne<Survey>().WithMany().HasForeignKey("SurveyId"));

            modelBuilder.Entity<FeedbackResponses>()
                .HasOne(fr => fr.Question)
                .WithMany(fq => fq.Responses)
                .HasForeignKey(fr => fr.QuestionId);

            modelBuilder.Entity<FeedbackSubmissions>()
                .HasOne(fs => fs.Response)
                .WithMany(fr => fr.Submissions)
                .HasForeignKey(fs => fs.ResponseId);

            modelBuilder.Entity<CustomerResponses>()
                .HasOne(cr => cr.Question)
                .WithMany(fq => fq.CustomerResponses)
                .HasForeignKey(cr => cr.QuestionId);

            modelBuilder.Entity<DistributionList>()
                .HasOne(dl => dl.User)
                .WithMany(u => u.DistributionLists)
                .HasForeignKey(dl => dl.UserId);

            modelBuilder.Entity<FeedbackQuestions>()
                .HasOne(fq => fq.Survey)
                .WithMany(s => s.Questions)
                .HasForeignKey(fq => fq.SurveyId);
        }
    }
}
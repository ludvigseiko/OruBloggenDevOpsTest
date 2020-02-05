using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OruBloggen.Models
{
    public class OruBloggenDbContext : DbContext
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<NotificationModel> Notifications { get; set; }
        public DbSet<MeetingModel> Meetings { get; set; }
        public DbSet<MessageModel> Messages { get; set; }
        public DbSet<PostModel> Posts { get; set; }
        public DbSet<PostReportModel> PostReports { get; set; }
        public DbSet<ProjectModel> Projects { get; set; }
        public DbSet<TeamModel> Teams { get; set; }
        public DbSet<UserMeetingModel> UserMeetings { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<NewsModel> News { get; set; }
        public DbSet<PostFilesModel> PostFiles { get; set; }
        public DbSet<ProjectFilesModel> ProjectFiles { get; set; }
        public DbSet<ProjectCommentModel> ProjectComments { get; set; }


        public OruBloggenDbContext() : base("OruBloggen") {
        }
    }


}
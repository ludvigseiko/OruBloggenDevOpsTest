namespace OruBloggen.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<OruBloggen.Models.OruBloggenDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(OruBloggen.Models.OruBloggenDbContext context)
        {
            context.Teams.AddOrUpdate(
                new TeamModel() { TeamName = "Informatik" },
                new TeamModel() { TeamName = "Ekonomi" },
                new TeamModel() { TeamName = "Statistik" },
                new TeamModel() { TeamName = "Juridik" }
                );


            context.Categories.AddOrUpdate(
                new CategoryModel() { CategoryName = "Okategoriserade", IsFormel = false },
                new CategoryModel() { CategoryName = "Okategoriserade", IsFormel = true },
                new CategoryModel() { CategoryName = "Fest", IsFormel = false},
                new CategoryModel() { CategoryName = "Semester", IsFormel = false },
                new CategoryModel() { CategoryName = "After work", IsFormel = false },
                new CategoryModel() { CategoryName = "Träning", IsFormel = false },
                new CategoryModel() { CategoryName = "Fritid", IsFormel = false },
                new CategoryModel() { CategoryName = "Utbildning", IsFormel = true },
                new CategoryModel() { CategoryName = "Seminarium", IsFormel = true },
                new CategoryModel() { CategoryName = "Ekonomi", IsFormel = true },
                new CategoryModel() { CategoryName = "Informatik", IsFormel = true },
                new CategoryModel() { CategoryName = "Juridik", IsFormel = true },
                new CategoryModel() { CategoryName = "Statistik", IsFormel = true }
                );

        }

    }
}

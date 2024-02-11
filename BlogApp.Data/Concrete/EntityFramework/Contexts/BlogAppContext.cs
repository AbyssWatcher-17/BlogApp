using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogApp.Data.Concrete.EntityFramework.Contexts
{
    public class BlogAppContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\ProjectsV13;Database=ProgrammersBlog;Trusted_Connection=True;Connect 
                    Timeout=30;MultipleActiveResultSets=True;");
        }

    }
}

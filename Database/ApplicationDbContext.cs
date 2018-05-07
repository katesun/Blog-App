using System;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Entities.Blog> Blogs { get; set; }
    }
}

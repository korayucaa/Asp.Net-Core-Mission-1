using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BGFGTTT\\MSSQLSERVER01;database=CoreBlogDb;integrated security=true;TrustServerCertificate=True ;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasMany(b => b.Comments) // Blog sınıfının Comments özelliği ile ilişkilendirme
                .WithOne(c => c.Blog)     // Comment sınıfının Blog özelliği ile ilişkilendirme
                .HasForeignKey(c => c.BlogID);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Blog)      // Comment sınıfının Blog özelliği ile ilişkilendirme
                .WithMany(b => b.Comments)// Blog sınıfının Comments özelliği ile ilişkilendirme
                .HasForeignKey(c => c.BlogID);
        }


        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
    }
}

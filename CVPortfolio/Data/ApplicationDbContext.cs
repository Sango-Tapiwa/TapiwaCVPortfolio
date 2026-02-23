using Microsoft.EntityFrameworkCore;
using CVPortfolio.Models;

namespace CVPortfolio.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Certification> Certifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Profile>().ToTable("Profile");
            modelBuilder.Entity<Education>().ToTable("Education");
            modelBuilder.Entity<Skill>().ToTable("Skill");
            modelBuilder.Entity<Project>().ToTable("Project");
            modelBuilder.Entity<Experience>().ToTable("Experience");
            modelBuilder.Entity<Certification>().ToTable("Certification");
        }
    }
}

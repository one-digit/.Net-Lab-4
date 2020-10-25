using Microsoft.EntityFrameworkCore;

namespace Lab4.Models
{
    public class SchoolCommunityContext : DbContext
    {
        public SchoolCommunityContext(DbContextOptions<SchoolCommunityContext> options) : base(options)
        {
        }

        public DbSet<Community> Communities { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<CommunityMembership> CommunityMemberships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Community>().ToTable("Community");
            modelBuilder.Entity<CommunityMembership>().HasKey(c => new { c.StudentID, c.CommunityID });
        }

    }
}

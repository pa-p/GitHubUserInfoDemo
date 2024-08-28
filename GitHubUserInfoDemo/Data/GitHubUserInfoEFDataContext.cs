using GitHubUserInfoDemo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GitHubUserInfoDemo.Data
{
    public class GitHubUserInfoEFDataContext : DbContext
    {
        public GitHubUserInfoEFDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<GitHubUser> GitHubUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GitHubUser>()
                .HasMany(e => e.Repos)
                .WithOne(e => e.GitHubUser)
                .HasForeignKey(e => e.GitHubUserId)
                .HasPrincipalKey(e => e.Id);

        }
    }
}

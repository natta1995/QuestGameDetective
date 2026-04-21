
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuestGameDetective.API.Models;
using QuestGameDetective.API.Data.Seed;

namespace QuestGameDetective.API.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<MurderCase> MurderCases { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Suspect> Suspects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<MurderCase>().HasData(GameSeedData.MurderCases);
            builder.Entity<Suspect>().HasData(GameSeedData.Suspects);
        }
    }
}
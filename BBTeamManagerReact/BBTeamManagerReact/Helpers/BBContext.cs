using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BBTeamManagerReact
{
    public class BBContext : DbContext
    {
        protected readonly IConfiguration configuration;

        //public DbSet<Team> Teams { get; set; }
        //public DbSet<Player> Players { get; set; }
        //public DbSet<Coach> Coaches { get; set; }
        //public DbSet<Race> Races { get; set; }
        //public DbSet<AgilitySkill> AgilitySkills { get; set; }
        //public DbSet<StrengthSkill> StrengthSkills { get; set; }
        //public DbSet<GeneralSkill> GeneralSkills { get; set; }
        //public DbSet<PassSkill> PassSkills { get; set; }
        //public DbSet<Mutation> Mutations { get; set; }
        public BBContext()
        {

        }
        public BBContext(IConfiguration configuration) 
        {
            this.configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("WebApiDatabase"));
            optionsBuilder.UseLazyLoadingProxies();
        }
        public DbSet<User> Users { get; set; }
    }
}

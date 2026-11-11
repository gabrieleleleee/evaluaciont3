using Microsoft.EntityFrameworkCore;
using EVALUACION_T3.Models;

namespace EVALUACION_T3.Data

{
    public class GuildaDbContext : DbContext
    {
        public GuildaDbContext(DbContextOptions<GuildaDbContext> options) : base(options)
        {
        }
        public DbSet<Aventurero> Aventureros { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }

        
    }
}

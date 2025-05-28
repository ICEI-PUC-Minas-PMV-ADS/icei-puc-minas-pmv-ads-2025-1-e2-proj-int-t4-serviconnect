using Microsoft.EntityFrameworkCore;

namespace ServiConnect.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }
        public DbSet<Prestador> prestador{ get; set; }

        public DbSet<Agendamento> agendamento { get; set; }        

 
    }
}


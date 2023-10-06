using Microsoft.EntityFrameworkCore;

namespace EauClaire.Models
{
  public class EauClaireContext : DbContext
  {
    public DbSet<Client> Clients { get; set; }
    public DbSet<Stylist> Stylists {get; set;}
    
    public EauClaireContext(DbContextOptions     options) : base(options) { }
  }
}
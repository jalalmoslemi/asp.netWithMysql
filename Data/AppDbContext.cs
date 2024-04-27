using Microsoft.EntityFrameworkCore;
using MySqlConnector.Model;

namespace MySqlConnector.Data
{
  public class AppDbContext : DbContext
  {
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var connectionString = "server=localhost;user=root;password=Mm.91151355;database=avaex";

      var serverConnection = new MySqlServerVersion(new Version(8,0,35));
      optionsBuilder.UseMySql(connectionString, serverConnection);
    }
  }
}
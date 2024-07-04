using System.Data.Entity;

namespace TareasPendientesWebApi.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<TareasPendientes> tareasPendientes { get; set; }

        public AppDbContext() : base("name=AppDbContext")
        {
        }
    }
}
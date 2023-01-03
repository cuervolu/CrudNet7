using CrudNet7.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet7.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Modelos
        public DbSet<Contacto> Contacto { get; set; }
    }
}

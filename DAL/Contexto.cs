using Microsoft.EntityFrameworkCore;
using Tarea1.Models;

namespace Tarea1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ocupaciones> Ocupaciones { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

    }
}

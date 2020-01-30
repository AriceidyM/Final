using Microsoft.EntityFrameworkCore;
using ProyectoFnal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFnal.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=.\SqlExpress;Database=ProyectoFerreteriaDb;truested_Connection =true"));
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPiGTodos.WebT.Models;

namespace WebAPiGTodos.WebT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Depto> Deptos { get; set; }

        public virtual DbSet<Ciudad> Ciudades { get; set; }

        public virtual DbSet<Tercero> Terceros { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trabajo_grupal.Models;

namespace Trabajo_grupal.Data
{
    public class Trabajo_grupalContext : DbContext
    {
        public Trabajo_grupalContext (DbContextOptions<Trabajo_grupalContext> options)
            : base(options)
        {
        }

        public DbSet<Trabajo_grupal.Models.Estudiante> Estudiante { get; set; } = default!;
    }
}

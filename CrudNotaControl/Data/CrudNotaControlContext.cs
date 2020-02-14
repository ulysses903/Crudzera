using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudNotaControl.Models.ViewModels;

namespace CrudNotaControl.Models
{
    public class CrudNotaControlContext : DbContext
    {
        public CrudNotaControlContext (DbContextOptions<CrudNotaControlContext> options)
            : base(options)
        {
        }

        public DbSet<Estado> Estado { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}

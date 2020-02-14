using CrudNotaControl.Models;
using CrudNotaControl.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNotaControl.Services
{
    public class EstadoService
    {
        private readonly CrudNotaControlContext _context;

        public EstadoService(CrudNotaControlContext context)
        {
            _context = context;
        }

        public List<Estado> FindAll()
        {
            return _context.Estado.ToList();
        }

    }
}

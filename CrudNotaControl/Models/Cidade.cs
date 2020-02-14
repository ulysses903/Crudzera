using CrudNotaControl.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNotaControl.Models
{
    public class Cidade
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Estado Estado { get; set; }

        public int EstadoId { get; set; }

        public Cidade()
        {
        }

        public Cidade(int id, string name, Estado estado)
        {
            Id = id;
            Name = name;
            Estado = estado;
        }
    }
}

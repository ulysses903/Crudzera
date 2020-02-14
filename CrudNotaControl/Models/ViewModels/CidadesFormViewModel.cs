using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNotaControl.Models.ViewModels
{
    public class CidadesFormViewModel
    {
        public Cidade Cidade { get; set; }

        public List<Estado> Estados { get; set; }
    }
}

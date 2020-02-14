using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNotaControl.Models.ViewModels
{
    public class EnderecoFormViewModel
    {
        public Endereco Endereco { get; set; }
        public List<Cidade> Cidades { get; set; }
    }
}

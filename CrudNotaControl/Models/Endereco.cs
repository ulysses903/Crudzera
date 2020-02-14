using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNotaControl.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public int Numero { get; set; }

        public Cidade Cidade { get; set; }

        public int CidadeId { get; set; }

        public Endereco()
        {
        }

        public Endereco(int id, string logradouro, string bairro, int numero, Cidade cidade)
        {
            Id = id;
            Logradouro = logradouro;
            Bairro = bairro;
            Numero = numero;
            Cidade = cidade;
        }
    }
}

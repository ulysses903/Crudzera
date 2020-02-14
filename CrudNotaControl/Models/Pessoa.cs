using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNotaControl.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Cpf { get; set; }

        public Endereco Endereco { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(int id, string name, DateTime dataNascimento, int cpf, Endereco endereco, string email, string phone)
        {
            Id = id;
            Name = name;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Endereco = endereco;
            Email = email;
            Phone = phone;
        }
    }
}

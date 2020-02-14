using CrudNotaControl.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNotaControl.Services
{
    public class EnderecoService
    {
        private readonly CrudNotaControlContext _context;

        public EnderecoService(CrudNotaControlContext context)
        {
            _context = context;
        }

        public List<Endereco> FindAll()
        {
            return _context.Endereco.Include(x => x.Cidade).Include(y => y.Cidade.Estado).ToList();
        }

        public void Insert(Endereco obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Delete(Endereco obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }

        public void Edit(Endereco endereco)
        {
            _context.Update(endereco);
            _context.SaveChanges();
        }

        public Endereco FindById(int id)
        {
            return _context.Endereco.Include(x => x.Cidade).Include(y => y.Cidade.Estado).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}

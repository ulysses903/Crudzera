using CrudNotaControl.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNotaControl.Services
{
    public class CidadeService
    {
        private readonly CrudNotaControlContext _context;

        public CidadeService(CrudNotaControlContext context)
        {
            _context = context;
        }

        public List<Cidade> FindAll()
        {
            return _context.Cidade.Include(x => x.Estado).ToList();
        }

        public void Insert(Cidade obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void Delete(Cidade obj)
        {
            _context.Remove(obj);
            _context.SaveChanges();
        }

        public void Edit(Cidade cidade)
        {
            _context.Update(cidade);
            _context.SaveChanges();
        }

        public Cidade FindById(int id)
        {
            return _context.Cidade.Include(x => x.Estado).Where(x => x.Id == id).FirstOrDefault();
        }

    }
}

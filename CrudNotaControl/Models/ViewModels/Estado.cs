using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNotaControl.Models.ViewModels
{
    public class Estado
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Estado()
        {
        }

        public Estado(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

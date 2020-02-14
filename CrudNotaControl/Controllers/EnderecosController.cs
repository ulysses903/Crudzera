using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudNotaControl.Models;
using CrudNotaControl.Models.ViewModels;
using CrudNotaControl.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrudNotaControl.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly CidadeService _cidadeService;
        private readonly EnderecoService _enderecoService;

        public EnderecosController(CidadeService cidadeService, EnderecoService enderecoService)
        {
            _cidadeService = cidadeService;
            _enderecoService = enderecoService;
        }

        public IActionResult Index()
        {
            var list = _enderecoService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var listCidades = _cidadeService.FindAll();
            var enderecoForm = new EnderecoFormViewModel { Cidades = listCidades};
            return View(enderecoForm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Endereco endereco)
        {
            _enderecoService.Insert(endereco);
            return RedirectToAction(nameof(Index));
        }

    }
}
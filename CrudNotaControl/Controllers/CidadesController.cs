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
    public class CidadesController : Controller
    {
        private readonly CidadeService _cidadeService;
        private readonly EstadoService _estadoService;

        public CidadesController(CidadeService cidadeService, EstadoService estadoService)
        {
            _cidadeService = cidadeService;
            _estadoService = estadoService;
        }

        public IActionResult Index()
        {
            try
            {

                var list = _cidadeService.FindAll();

                return View(list);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public IActionResult Create()
        {
            var listEstados = _estadoService.FindAll();
            var cidadeForm = new CidadesFormViewModel { Estados = listEstados };
            return View(cidadeForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cidade cidade)
        {
            _cidadeService.Insert(cidade);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _cidadeService.Delete(_cidadeService.FindById(id));
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            var cidade = _cidadeService.FindById(id);
            var estados = _estadoService.FindAll();
            var cidadeFormViewModel = new CidadesFormViewModel { Cidade = cidade, Estados = estados };
            return View(cidadeFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cidade cidade)
        {
            try
            {
                _cidadeService.Edit(cidade);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
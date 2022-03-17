using CadastroDeVeciulos.Visualizacao.Models;
using CadastroVeiculo.Aplicacao.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroDeVeciulos.Visualizacao.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProprietarioService _proprietarioService;

        public HomeController(ILogger<HomeController> logger, IProprietarioService proprietarioService)
        {
            _logger = logger;
            _proprietarioService = proprietarioService;
        }

        public async Task<IActionResult> Index()
        {
            var proprietarios = await _proprietarioService.PegaTodosProprietariosAsync();

            return View(proprietarios.proprietariosQuePossuo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

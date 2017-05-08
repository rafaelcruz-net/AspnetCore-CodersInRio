using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sample.Services;
using Sample.ViewModel;

namespace Sample.Controllers
{
    public class HomeController : Controller
    {
        
        public ICalculadora service { get; set; }

        public HomeController([FromServices]ICalculadora service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(CalculadoraViewModel model)
        {
            var result = 0;

            if (model.OperationType == "Somar")
                result = service.Soma(model.Param1, model.Param2);
            else if (model.OperationType == "Subtrair")
                result = service.Subtrair(model.Param1, model.Param2);
            else if (model.OperationType == "Multiplicar")
                result = service.Multiplicar(model.Param1, model.Param2);
            else if (model.OperationType == "Dividir")
                result = service.Dividir(model.Param1, model.Param2);

            ViewBag.Resultado = result;

            return View();


        }

    }
}

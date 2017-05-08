using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sample.Services;

namespace Sample.Controllers
{
    [Produces("application/json")]
    [Route("api/Calculadora")]
    public class CalculadoraController : Controller
    {

        public ICalculadora service { get; set; }

        public CalculadoraController(ICalculadora service)
        {
            this.service = service;
        }

        [HttpGet("{type}/{x}/{y}")]
        public IActionResult Calcular(string type, int x, int y)
        {
            var result = 0;

            if (type == "Somar")
                result = service.Soma(x, y);
            else if (type == "Subtrair")
                result = service.Subtrair(x, y);
            else if (type == "Multiplicar")
                result = service.Multiplicar(x, y);
            else if (type == "Dividir")
                result = service.Dividir(x, y);

            return Ok(new
            {
                Result = result
            });

        }
    }
}
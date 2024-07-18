using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace EjemploAPIRest
{
    [Route("Operaciones")]
    [ApiController]
    public class OperacionesController : ControllerBase
    {
        [Route("CalcularMayorDe2")]
        [HttpGet]
        public IActionResult CalcularNumeroMayor(int numero1, int numero2)
        {
            if (numero1 == numero2) { return Ok(new { resultado = "Los números son iguales" }); }

            if (numero1 > numero2) { return Ok($"El número {numero1} es mayor"); }

            return Ok($"El número {numero2} es mayor");
        }

    }
}

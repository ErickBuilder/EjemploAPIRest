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
            int valorMayor = 0;

            if (numero1 == numero2) {   valorMayor = numero1; }

            if (numero1 > numero2)  {   valorMayor = numero1; }

            if (numero2 > numero1)  {   valorMayor = numero2; }

            return Ok(new { resultado = $"El numero enviado es el {valorMayor}" });
        }

    }
}

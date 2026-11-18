using Microsoft.AspNetCore.Mvc;

namespace Cuadrado.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MathController : ControllerBase
{
    [HttpGet("cuadrado/{numero}")]
    public IActionResult CalcularCuadrado(int numero)
    {
        if (numero < 0)
        {
            return BadRequest(new
            {
                mensaje = "No se permiten números negativos."
            });
        }

        long cuadrado = (long)numero * numero;

        return Ok(new
        {
            numero,
            cuadrado
        });
    }
}

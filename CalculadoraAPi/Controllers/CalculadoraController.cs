using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization;

namespace CalculadoraAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CalculadoraController : ControllerBase
    {
      
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }
        [HttpGet("Calcular")]
        public IActionResult Calcular(double valor1, double valor2, OperacaoMatematica operacao)
        {
            double resultado;
            

            switch (operacao)
            {
                case OperacaoMatematica.Adicao:
                    resultado = valor1 + valor2;
                    break;
                case OperacaoMatematica.Subtracao:
                    resultado = valor1 - valor2;
                    break;
                case OperacaoMatematica.Multiplicacao:
                    resultado = valor1 * valor2;
                    break;
                case OperacaoMatematica.Divisao:
                    if (valor2 == 0)
                        return BadRequest("Divisão por zero não permitida.");
                    resultado = valor1 / valor2;
                    break;
                default:
                    return BadRequest("Operação inválida.");
            }

            return Ok(resultado);
        }

        public enum OperacaoMatematica
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Business;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TotaisController : ControllerBase
    {
        IJogoService _jogoService;

        public TotaisController(IJogoService jogoService)
        {
            _jogoService = jogoService;
        }

        [HttpGet]
        public IActionResult ObterQuantidadeMesas()
        {
            //retornar quantidade de mesas
            int qtd = _jogoService.RetornarQuantidadeMesas();
            return Ok(new { QuantidadeMesas = qtd });
            // {QuantidadeMesas : 2}
        }
    }
}
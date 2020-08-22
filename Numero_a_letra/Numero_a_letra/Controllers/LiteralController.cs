using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Numero_a_letra.Helper;

namespace Numero_a_letra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        public string Literalget(int numero)
        {
            return Conversores.NumeroALetras(numero);
        }

        [HttpPost]
        public string Literalpost([FromHeader] int numero)
        {
            return Conversores.NumeroALetras(numero);
        }

    }
}

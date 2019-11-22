using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClientesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET api/clientes
        [HttpGet]
        public IActionResult Get()
        {
            var c1 = new Cliente(1, "Cliente ABC");
            var c2 = new Cliente(2, "Cliente XYZ");
            return Ok(new List<Cliente>{c1,c2});
        }
    }

    public class Cliente
    {
        public int Id {get; set;}
        public string Nome {get ;set;}

        public Cliente(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
    }
}

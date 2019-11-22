using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProdutosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        // GET api/produtos
        [HttpGet]
        public IActionResult Get()
        {
            var p1 = new Produto(1, "Produto 123");
            var p2 = new Produto(2, "Produto 456");
            return Ok(new List<Produto> { p1, p2 });
        }

        // GET api/produtos/Categorias
        [HttpGet("categorias")]
        public IActionResult GetCategorias()
        {
            return Ok(new List<string> { "Categoria A", "Categoria B" });
        }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Produto(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }
    }
}

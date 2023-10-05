using Microsoft.AspNetCore.Mvc;
using ProdutosApiAula.Models;
using ProdutosApiAula.Repositories;

namespace ProdutosApiAula.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        [HttpGet(Name = "GetProduto")]
        public IEnumerable<Produto> Get()
        {
            return MockDB.GetProdutos();
        }

        [HttpGet("{id}")]
        public Produto GetProduto(int id)
        {
            return MockDB.GetProduto(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            MockDB.Produtos.Add(produto);
            return CreatedAtRoute("GetProduto", new { id = produto.Id }, produto);
        }
    }
}

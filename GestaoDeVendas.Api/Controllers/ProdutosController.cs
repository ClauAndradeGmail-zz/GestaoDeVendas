using GestaoDeVendas.Api.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeVendas.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private static readonly List<Produto> produtos = GerarProdutos(5);
    private static List<Produto> GerarProdutos(int numero)
    {
        return Enumerable.Range(1, numero).Select(index => new Produto 
        { 
            Id = index,
            Descricao = $"Produto{index}",
            Preco = index,
            Quantidade = index+1
        }).ToList();
    }

    [HttpGet]
    public ActionResult<List<Produto>> GetProdutos()
    {
        return produtos;
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Produto> GetProduto(int id)
    {
        var produto = produtos.FirstOrDefault((p) => p.Id == id);
        if(produto == null)
        {
            return NotFound();
        }
        return produto;
    }

    // POST: api/produtos
    [HttpPost]
    public void AdicionaProduto([FromBody] Produto produto)
    {
        produtos.Add(produto);
    }
    // PUT: api/produto/5
    [HttpPut("{id}")]
    public void EditaProduto(int id, [FromBody] Produto produto)
    {
        int index = produtos.FindIndex((p) => p.Id == id);
        if (index != -1)
            produtos[index] = produto;
    }
    // DELETE: api/protudo/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        int index = produtos.FindIndex((p) => p.Id == id);
        if (index != -1)
            produtos.RemoveAt(index);
    }
}

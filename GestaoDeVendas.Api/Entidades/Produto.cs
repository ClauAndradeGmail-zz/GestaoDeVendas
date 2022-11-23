using GestaoDeVendas.Domain.TabelasDb;

namespace GestaoDeVendas.Api.Entidades;

public class Produto
{
    public int Id { get; set; }
    public string? Descricao { get; set; }
    public decimal? Preco { get; set; }
    public int Quantidade { get; set; }
    public int CategoriaId { get; set; }
    public string? CategoriaNome { get; set; }

    public CategoriaDb? Categoria { get; set; }
}

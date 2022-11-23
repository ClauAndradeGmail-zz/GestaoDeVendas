namespace GestaoDeVendas.Api.Entidades;

public class Pedido
{
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public int UsuarioId { get; set; }
    public int Quantidade { get; set; }
    public decimal? Preco { get; set; }
    public decimal? PrecoTotal { get; set; }
    public string? ProdutoNome { get; set; }
}

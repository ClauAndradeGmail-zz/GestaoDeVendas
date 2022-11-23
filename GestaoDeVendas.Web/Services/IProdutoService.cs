using GestaoDeVendas.Domain.TabelasDb;

namespace GestaoDeVendas.Web.Services;

public interface IProdutoService
{
    Task<IEnumerable<ProdutoDb>> GetItens();
    Task<ProdutoDb> GetItem(int id);
}

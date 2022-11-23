using GestaoDeVendas.Api.Entidades;
using GestaoDeVendas.Api.Repositorios.Interface;

namespace GestaoDeVendas.Api.Repositorios.Contexto
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public Task<IEnumerable<Categoria>> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> GetItens()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> GetItensPorCategoria(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using GestaoDeVendas.Api.Entidades;

namespace GestaoDeVendas.Api.Repositorios.Interface;

public interface IProdutoRepositorio
{
    //obter os produtos
    Task<IEnumerable<Produto>> GetItens();

    //obter um produto específico
    Task<Produto> GetItem(int id);

    //produto de uma categoria
    Task<IEnumerable<Produto>> GetItensPorCategoria(int id);

    //obter as categorias
    Task<IEnumerable<Categoria>> GetCategorias();
}

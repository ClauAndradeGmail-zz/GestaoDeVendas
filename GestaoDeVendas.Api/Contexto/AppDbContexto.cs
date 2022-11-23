using GestaoDeVendas.Api.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeVendas.Api.Contexto;

public class AppDbContexto: DbContext
{
    public AppDbContexto(DbContextOptions<AppDbContexto> options): base(options)
    { }

    //mapeamento
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Categoria> Categorias { get;set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
}

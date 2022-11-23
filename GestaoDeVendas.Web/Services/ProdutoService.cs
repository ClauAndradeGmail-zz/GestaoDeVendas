using GestaoDeVendas.Domain.TabelasDb;
using System.Net.Http.Json;
using System.Net;

namespace GestaoDeVendas.Web.Services;

public class ProdutoService : IProdutoService
{
    public HttpClient _httpClient;
    public ILogger<ProdutoService> _logger;

    public ProdutoService(HttpClient httpClient, ILogger<ProdutoService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<ProdutoDb> GetItem(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/produtos/{id}");
            if (response.IsSuccessStatusCode) //status code 200-299
            {
                if (response.StatusCode == HttpStatusCode.NoContent) //status 204
                {
                    return default(ProdutoDb); //retorna os valores padrão/empty
                }
                return await response.Content.ReadFromJsonAsync<ProdutoDb>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro a obter produto pelo Id = {id} - {message}");
                throw new Exception($"Status Code : {response.StatusCode} - {message}");
            }
        }
        catch (Exception)
        {
            _logger.LogError($"Erro a obter produto pelo Id = {id}");
            throw;
        }
    }

    public async Task<IEnumerable<ProdutoDb>> GetItens()
    {
        try
        {
            var produtosDb = await _httpClient
                        .GetFromJsonAsync<IEnumerable<ProdutoDb>>("api/produtos");
            return produtosDb;
        }
        catch (Exception)
        {
            _logger.LogError("Erro ao acessar produtos: api/produtos");
            throw;
        }
    }
}

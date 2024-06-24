using Ecommerce.Management.Web.Requests;
using Ecommerce.Management.Web.ViewModels;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;

namespace Ecommerce.Management.Web.Services
{
    public class EcommerceAPI
    {
        private readonly HttpClient _httpClient;

        public EcommerceAPI(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("EcommerceApi");
        }

        // Buscar todos os produtos
        public async Task<IEnumerable<ProdutoViewModel>> GetProductsAsync()
        {
            return await _httpClient
                .GetFromJsonAsync<IEnumerable<ProdutoViewModel>>("Product");
        }

        // Buscar todas as categorias


        // Buscar todas as subcategorias
        public async Task<List<SubcategoriaViewModel>> GetSubcategoriesAsync()
        {
            return await _httpClient
                .GetFromJsonAsync<List<SubcategoriaViewModel>>("Subcategory");
        }

        // Cadastrar nova categoria


        public async Task CadastrarProdutoAsync(CreateProductRequest request)
        {
            await _httpClient.PostAsJsonAsync("Product", request);
        }

        // Cadastrar produto

    }
}

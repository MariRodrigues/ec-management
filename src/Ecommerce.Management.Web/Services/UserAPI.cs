namespace Ecommerce.Management.Web.Services
{
    public class UserAPI
    {
        private readonly HttpClient _httpClient;

        public UserAPI(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("UserApi");
        }
    }
}

namespace API.API.BLL
{
    public class Client
    {
        private HttpClient _HttpClient;

        public Client(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }
        public async Task asd()
        {
            await _HttpClient.GetAsync("");
        }
        
    }
}

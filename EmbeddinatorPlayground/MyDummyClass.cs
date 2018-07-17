using System;
using System.Net.Http;

namespace EmbeddinatorPlayground
{
    public class MyDummyClass
    {
        HttpClient _client;

        public MyDummyClass(HttpClient client = null)
        {
            _client = client == null ? new HttpClient() : null;
        }

        public async void FetchData()
        {
            HttpResponseMessage response = await _client.GetAsync("https://jsonplaceholder.typicode.com/users");
            Console.WriteLine(response.IsSuccessStatusCode ? "OK" : "KO");
        }
    }
}
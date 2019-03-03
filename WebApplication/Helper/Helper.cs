using System;
using System.Net.Http;
namespace WebApplication.Helper
{
    public class Data
    {
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44337/api/");
            return client;
        }
    }
}

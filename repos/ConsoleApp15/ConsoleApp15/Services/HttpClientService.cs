using ConsoleApp15.Api;
using ConsoleApp15.Exceptions;
using ConsoleApp15.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace ConsoleApp15.Services
{
    public class HttpClientService<T> where T :class, IEntity
    {
        private readonly HttpClient _http;
        public HttpClient Http { get => _http; }

        public HttpClientService(HttpClient http)
        {
            _http = http;
        }
        public async Task<ICollection<T>> GetAllAsync(string controller)
        {
            var response = await _http.GetAsync($"{Constants._baseUrl}/{controller}");
            if (!response.IsSuccessStatusCode)
            {
                throw new NotFoundException("Could not get json");
            }
            string json = await response.Content.ReadAsStringAsync();
            List<T> items = JsonConvert.DeserializeObject<List<T>>(json);
            return items;
        }
        public async Task<T> GetAsync(string controller,int id)
        {
            var response = await _http.GetAsync($"{Constants._baseUrl}/{controller}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new NotFoundException("Could not get json");
            }
            string json = await response.Content.ReadAsStringAsync();
            T item = JsonConvert.DeserializeObject<T>(json);
            return item;
        }
    }
}

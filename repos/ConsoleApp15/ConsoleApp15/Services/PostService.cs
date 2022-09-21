using ConsoleApp15.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;
using System.Threading.Tasks;
using ConsoleApp15.Interfaces;
using ConsoleApp15.Api;
using ConsoleApp15.Models;

namespace ConsoleApp15.Services
{
    public class PostService 
    {
        private readonly HttpClientService<Post> _httpClient;

        public PostService(HttpClientService<Post> httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ICollection<Post>> GetAllAsync()
        {
            return await _httpClient.GetAllAsync("posts");
        }
        public async Task<Post> GetAsync(int id)
        {
            return await _httpClient.GetAsync("posts",id);
        }
    }
}

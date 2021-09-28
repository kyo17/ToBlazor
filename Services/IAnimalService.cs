using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ToBlazor.Interfaces;
using ToBlazor.Models;

namespace ToBlazor.Services
{
    public class IAnimalService : IAnimal
    {
        private readonly HttpClient http;
        private readonly string url;

        public IAnimalService(HttpClient client, IConfiguration config)
        {
            this.http = client;
            url = config.GetConnectionString("Url");
        }

        public async Task delete(string id)
        {
           await http.DeleteAsync($"{url}/videojuego/{id}");
        }

        public async Task<IEnumerable<VideoJuego>> getAll()
        {
            return JsonSerializer.Deserialize<IEnumerable<VideoJuego>>(
                await http.GetStringAsync($"{url}/videojuego"));
        }

        public async Task<VideoJuego> getById(string id)
        {
            return JsonSerializer.Deserialize<VideoJuego>(
                await http.GetStringAsync($"{url}/videojuego/{id}"));
        }

        public async Task save(VideoJuego animal)
        {
             var json = new StringContent(JsonSerializer.Serialize(animal),
             Encoding.UTF8, "application/json");
             await http.PostAsync(url + "/videojuego", json);
            //await http.PostAsJsonAsync($"{url}/videojuego", animal);
        }

        public async Task update(VideoJuego animal)
        {
            var json = new StringContent(JsonSerializer.Serialize(animal),
                Encoding.UTF8, "application/json");
            await http.PutAsync($"{url}/videojuego/{animal.idVJ}", json);
            
        }
    }
}

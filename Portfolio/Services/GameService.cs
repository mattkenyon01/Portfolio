using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class GameService
    {
        private readonly HttpClient _http;

        public GameService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<GameItem>> GetAllAsync()
        {
            // fetch JSON via HTTP from wwwroot/data/games.json
            var result = await _http.GetFromJsonAsync<List<GameItem>>("data/games.json");
            return result ?? new List<GameItem>();
        }
    }
}

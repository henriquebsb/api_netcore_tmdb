using Domain.CommandResult;
using Domain.Repositories;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class GenreRepository : BaseRepository, IGenreRepository
    {
        public async Task<GenreCommandResult> ListMovieGenres()
        {
            try
            {
                var http = HttpRequest();
                var apiKey = ApiKey();
                var url = UrlConnection() + $"genre/movie/list?api_key={apiKey}&language=pt-BR";

                HttpResponseMessage result = await http.GetAsync(url);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = result.Content;
                    string jsonString = await content.ReadAsStringAsync();

                    var data = JsonSerializer.Deserialize<GenreCommandResult>(jsonString);

                    return data;
                }
                else
                {
                    throw new Exception($"Error: {result.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ListMovieGenres(): {ex.Message}", ex);
            }
        }
    }
}

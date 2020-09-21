using Domain.Repositories;
using System;
using Domain.CommandResult;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

namespace Infrastructure.Repositories
{
    public class MovieRepository : BaseRepository, IMovieRepository
    {
        public async Task<MovieCommandResult> ListUpcomingMovies(string page)
        {
            try
            {
                var http = HttpRequest();
                var apiKey = ApiKey();
                var url = UrlConnection() + $"movie/upcoming?api_key={apiKey}&language=pt-BR&page={page}";

                HttpResponseMessage result = await http.GetAsync(url);

                if (result.StatusCode == HttpStatusCode.OK)
                {
                    var content = result.Content;
                    string jsonString = await content.ReadAsStringAsync();

                    var data = JsonSerializer.Deserialize<MovieCommandResult>(jsonString);

                    return data;
                }
                else
                {
                    throw new Exception($"Error: {result.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ListUpcomingMovies(): {ex.Message}", ex);
            }
        }
    }
}
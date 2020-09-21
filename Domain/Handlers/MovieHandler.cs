using Domain.CommandResult;
using Domain.Entities;
using Domain.Repositories;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class MovieHandler
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IGenreRepository _genreRepository;
        public MovieHandler(IMovieRepository movieRepository, IGenreRepository genreRepository)
        {
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;
        }

        public async Task<dynamic> ListMoviesUpcomingWithGenres(string page)
        {
            var genres = await _genreRepository.ListMovieGenres();
            var upcomingMovies = await _movieRepository.ListUpcomingMovies(page);
            var resultList = new List<ResultCommand>();

            foreach (var movie in upcomingMovies.results)
            {
                var result = new ResultCommand();

                result.Filme = movie.title;
                result.DataLancamento = movie.release_date;

                var movieGenres = genres.genres.Where(genre => movie.genre_ids.Any(item => item.Equals(genre.id)));

                foreach (var item in movieGenres)
                {
                    result.Generos.Add(item.name);
                }

                resultList.Add(result);
            }

            return resultList;
        }
    }
}

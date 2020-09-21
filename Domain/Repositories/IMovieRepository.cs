using Domain.CommandResult;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IMovieRepository
    {
        Task<MovieCommandResult> ListUpcomingMovies(string page);
    }
}

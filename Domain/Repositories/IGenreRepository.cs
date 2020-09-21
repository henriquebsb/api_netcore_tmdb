using Domain.CommandResult;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IGenreRepository
    {
        Task<GenreCommandResult> ListMovieGenres();
    }
}

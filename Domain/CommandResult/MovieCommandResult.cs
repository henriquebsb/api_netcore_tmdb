using Domain.Entities;
using System.Collections.Generic;

namespace Domain.CommandResult
{
    public class MovieCommandResult
    {
        public MovieCommandResult()
        {
            results = new List<Movie>();
        }

        public List<Movie> results { get; set; }
        public int page { get; set; }
        public int total_results { get; set; }
        public Period dates { get; set; }
        public int total_pages { get; set; }
    }
}

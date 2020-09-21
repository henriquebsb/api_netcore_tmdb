﻿using Domain.CommandResult;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IMovieRepository
    {
        Task<MovieCommandResult> ListUpcomingMovies(string page);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.CommandResult;
using Domain.Entities;
using Domain.Handlers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;

namespace Api.Controllers
{
    [Route("movie/")]
    public class MovieController : ControllerBase
    {
        private readonly MovieHandler _handler;

        public MovieController(MovieHandler handler)
        {
            _handler = handler;
        }

        [HttpGet]
        [Route("upcoming/{page}")]
        [Produces("application/json")]
        public Task<dynamic> Upcoming(string page)
        {
            try
            {
                var _result = _handler.ListMoviesUpcomingWithGenres(page);

                return _result;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error: {ex.Message}", ex);
            }
        }
    }
}

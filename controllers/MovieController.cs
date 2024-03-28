using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalPOCService.functionality;
using finalPOCService.models;
using Microsoft.AspNetCore.Mvc;

namespace finalPOCService.controllers
{
    [ApiController]
    [Route("exl/[controller]")]
    public class MovieController : ControllerBase
    {
        IMovieFunctionality functionality;
        public MovieController(IMovieFunctionality _functionality)
        {
            functionality = _functionality;
        }


        [HttpGet]
        [Route("getMovies")]
        public IActionResult getMovies()
        {
            return Ok(functionality.getMovies());
        }


        [HttpGet]
        [Route("searchMovie")]
        public IActionResult searchMovieById(int mid)
        {
            return Ok(functionality.searchMovies(mid));
        }


        [HttpPost]
        [Route("addMovie")]
        public IActionResult addMovie(Movie movie)
        {
            return Ok(functionality.addMovies(movie));
        }
    }
}
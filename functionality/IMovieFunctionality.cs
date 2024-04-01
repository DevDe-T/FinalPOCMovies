using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalPOCService.models;
using Microsoft.EntityFrameworkCore;

namespace finalPOCService.functionality
{
    public interface IMovieFunctionality
    {
        public DbSet<Movie> getMovies();

        public Movie searchMovies(int mid);

        public int addMovies(Movie movie);

        public int deleteMovie(int id);

        public int editMovie(Movie movie);
    }
}
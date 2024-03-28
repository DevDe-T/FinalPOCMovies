using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalPOCService.database;
using finalPOCService.functionality;
using finalPOCService.models;
using Microsoft.EntityFrameworkCore;

namespace finalPOCService.service
{
    public class MovieOperations : IMovieFunctionality
    {
        DatabaseContext db;

        public MovieOperations(DatabaseContext _db)
        {
            db = _db;
        }
        int IMovieFunctionality.addMovies(Movie movie)
        {
            db.movies.Add(movie);
            return db.SaveChanges();
        }

        DbSet<Movie> IMovieFunctionality.getMovies()
        {
            return db.movies;
        }

        Movie IMovieFunctionality.searchMovies(int mid)
        {
            var res = db.movies.Where(x => x.mid == mid).First();
            if(res == null)
            {
                return null;
            }
            else
            {
                return res;
            }
        }
    }
}
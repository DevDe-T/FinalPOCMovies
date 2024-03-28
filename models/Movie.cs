using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace finalPOCService.models
{
    public class Movie
    {
        [Key]
        public int mid { get; set; }
        public string? movieName { get; set; }

        public int movieYear { get; set; }

        public string? movieCast { get; set; }
    }
}
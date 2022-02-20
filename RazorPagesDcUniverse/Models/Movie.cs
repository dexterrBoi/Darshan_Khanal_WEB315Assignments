using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesDcUniverse.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Actors { get; set; }
        public decimal Ratings { get; set; }
    }
}
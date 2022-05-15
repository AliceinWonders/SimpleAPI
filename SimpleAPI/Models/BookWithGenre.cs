using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleAPI.Models
{
    public class BookWithGenres
    {
        public BookWithGenres(ICollection<string> titles, string genre)
        {
            Titles = titles;
            Genre = genre;
        }

        public ICollection<string> Titles { get; set; }
        public string Genre { get; set; }
        
       
        
    }
}
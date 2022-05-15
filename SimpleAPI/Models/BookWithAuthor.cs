using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleAPI.Models
{
    public class BooksWithAuthor
    {
        public BooksWithAuthor(ICollection<string> titles, string author)
        {
            Titles = titles;
            Author = author;
        }

        public ICollection<string> Titles { get; set; }
        public string Author { get; set; }

    }
}
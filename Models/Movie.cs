using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {

        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        public Genre Genre { get; set; }


        [Required]
        public byte GenreID { get; set; }       


        [Column(TypeName = "Date")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }


        [Column(TypeName ="Date")]
        public DateTime DateAdded { get; set; }


        [Required]
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }


    }
}
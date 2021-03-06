﻿using System;
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


        [Required(ErrorMessage = "Genre is required")]
        public byte GenreId { get; set; }


        
        public virtual Genre Genre { get; set; }



        [Column(TypeName = "Date")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }


        [Column(TypeName ="Date")]
        public DateTime DateAdded { get; set; }


        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }


    }
}
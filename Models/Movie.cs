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

        [Required]
        public string Genre { get; set; }


        [Column(TypeName ="Date")]
        public DateTime ReleaseDate { get; set; }


        [Column(TypeName ="Date")]
        public DateTime DateAdded { get; set; }


        [Required]
        public int NumberInStock { get; set; }


    }
}
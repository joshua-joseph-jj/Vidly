﻿using System.Collections.Generic;
using Vidly.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Vidly.ViewModels
{


    public class MovieFormViewModel
    {

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }



        public IEnumerable<Genre> Genres { get; set; }



        public Movie Movie { get; set; }


        public int? Id { get; set; }



       // [Required]
        [StringLength(255)]
        public string Name { get; set; }



        [Display(Name = "Genre")]
       // [Required]
        public byte? GenreId { get; set; }




        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }



        [Column(TypeName = "Date")]
        public DateTime DateAdded = DateTime.Now;



        [Display(Name ="Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInStock { get; set; }




        public MovieFormViewModel()
        {
            Id = 0;
        }


        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
            DateAdded = movie.DateAdded;
            
        }


       
            

    }
}
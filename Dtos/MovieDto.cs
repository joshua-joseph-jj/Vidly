using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }


        [Required(ErrorMessage = "Genre is required")]
        public byte GenreId { get; set; }


        [Column(TypeName = "Date")]
        public DateTime ReleaseDate { get; set; }


        [Column(TypeName = "Date")]
        public DateTime DateAdded { get; set; }


        [Required]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}
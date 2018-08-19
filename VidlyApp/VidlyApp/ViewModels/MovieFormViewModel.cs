using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyApp.Models;

namespace VidlyApp.ViewModels
{
    public class MovieFormViewModel
    {
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
        }
        public IEnumerable<Genre> Genres { get; set; }
        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }
        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        [Required]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Movie";
                return "New Movie";
            }
        }
    }
}
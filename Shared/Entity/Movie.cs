using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ProySprintIII.Shared.Entity
{
    public class Movie
    {
        
        public int Id{get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string MovieName{get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public bool EnCartelera{get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Poster{get;set;}
        public string Trailer{get;set;}
        [Required (ErrorMessage = "El campo {0} es requerido")]
        public string Sinopsis{get;set;}
        public int Score{get;set;}
        public DateTime Premier{get;set;}
        public List<CategoryMovie> CategoriesMovie{get;set;} = new List<CategoryMovie>();
        public List<MovieCast> MoviesCast{get;set;}
        public string ShortName{
            get{
                if (string.IsNullOrWhiteSpace(MovieName))
                {
                    return null;
                }
                if (MovieName.Length >60)
                {
                    return MovieName.Substring(0,60) +"...";
                }else {
                    return MovieName;
                }
            }
            }
    }
}

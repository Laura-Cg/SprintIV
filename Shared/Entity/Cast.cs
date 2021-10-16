using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace ProySprintIII.Shared.Entity
{
    public class Cast
    {
        public int Id {get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public string ActorName{get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public DateTime? BirthDate {get;set;}        
        public string ActorImage{get;set;}
        [Required(ErrorMessage="El campo {0} es requerido")]
        public int KnowCredits {get;set;}       
        public string Biography {get;set;}       
        public string Nominations {get;set;}
        public List<MovieCast> MoviesCast{get;set;}
    }
}

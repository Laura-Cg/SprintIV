using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProySprintIII.Shared.Entity
{
    public class Category
    {
        public int Id{get;set;}
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name{get;set;}
        public List <CategoryMovie> CategoryMovie {get;set;}
    }
}
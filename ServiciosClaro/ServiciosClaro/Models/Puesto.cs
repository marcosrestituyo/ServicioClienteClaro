using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiciosClaro.Models
{
    public class Puesto
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Puesto")]
        public string Nombre { get; set; }
    }
}
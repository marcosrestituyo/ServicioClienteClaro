using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiciosClaro.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Empleado")]
        public string Nombre { get; set; }

        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [Required]
        [Display(Name = "Puesto")]
        public int IdPuesto { get; set; }
        public Puesto Puesto { get; set; }

        [Required]
        [Display(Name = "Correo Electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Cedúla")]
        public string Cedula { get; set; }

        [Display(Name = "Fecha de contratación")]
        [DataType(DataType.Date)]
        public DateTime FechaContratacion { get; set; }

        [Required]
        [Display(Name = "Cuenta")]
        public int IdCuenta { get; set; }
        public Cuenta Cuenta { get; set; }

    }
}
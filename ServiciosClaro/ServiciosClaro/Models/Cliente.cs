using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiciosClaro.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Cliente")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(300)]
        [Display(Name = "Drección")]
        public string Direccion { get; set; }

        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [Display(Name = "Correo Electrónico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Cuenta")]
        public int IdCuenta { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
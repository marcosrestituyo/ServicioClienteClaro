using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiciosClaro.Models
{
    public class RolCuenta
    {
        public int Id { get; set; }
        public int IdCuenta { get; set; }
        public Cuenta Cuenta { get; set; }

        public int IdRol { get; set; }
        public Rol Rol { get; set; }
    }
}
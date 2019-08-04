namespace ServiciosClaro.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ServiciosClaro.Models.ServiciosClaroContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ServiciosClaro.Models.ServiciosClaroContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Roles.AddOrUpdate(
              p => p.RolName,
              new Rol { Id = 1, RolName = "Admin" },
              new Rol { Id = 2, RolName = "Empleado" },
              new Rol { Id = 3, RolName = "Cliente" }
            );

            context.Puestos.AddOrUpdate(
              p => p.Nombre,
              new Puesto { Id = 1, Nombre = "Tecnico" },
              new Puesto { Id = 2, Nombre = "Servicio" },
              new Puesto { Id = 3, Nombre = "Adminnistrador" }
            );

            context.Cuentas.AddOrUpdate(
              p => p.Usuario,
              new Cuenta { Id = 1, Usuario = "MarcosRestituyo", Clave = "Markito2000" }
            );


            context.RolCuentas.AddOrUpdate(
              p => p.IdCuenta,
              new RolCuenta { Id = 1, IdCuenta = 1, IdRol = 1 }
            );


            context.Empleados.AddOrUpdate(
              p => p.Nombre,
              new Empleado { Id = 1, Nombre = "Marcos Restituyo", Telefono = "(809) 616-9743", IdPuesto = 3,
                  Email = "20175534@itla.edu.do", Cedula = "001-25412365-6", FechaContratacion = new DateTime(year: 2019, month: 8, day: 12), IdCuenta = 1 }
            );

            

            //
        }
    }
}

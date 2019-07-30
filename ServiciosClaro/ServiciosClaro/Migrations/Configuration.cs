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

            //
        }
    }
}

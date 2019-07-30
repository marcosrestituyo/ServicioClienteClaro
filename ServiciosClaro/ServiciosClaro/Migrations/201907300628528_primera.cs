namespace ServiciosClaro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Direccion = c.String(nullable: false, maxLength: 300),
                        Telefono = c.String(),
                        Email = c.String(),
                        IdCuenta = c.Int(nullable: false),
                        Cuenta_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cuentas", t => t.Cuenta_Id)
                .Index(t => t.Cuenta_Id);
            
            CreateTable(
                "dbo.Cuentas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 60),
                        Clave = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegistrarClientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false, maxLength: 60),
                        Clave = c.String(nullable: false, maxLength: 30),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Direccion = c.String(nullable: false, maxLength: 300),
                        Telefono = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolCuentas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdCuenta = c.Int(nullable: false),
                        IdRol = c.Int(nullable: false),
                        Cuenta_Id = c.Int(),
                        Rol_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cuentas", t => t.Cuenta_Id)
                .ForeignKey("dbo.Rols", t => t.Rol_Id)
                .Index(t => t.Cuenta_Id)
                .Index(t => t.Rol_Id);
            
            CreateTable(
                "dbo.Rols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RolName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolCuentas", "Rol_Id", "dbo.Rols");
            DropForeignKey("dbo.RolCuentas", "Cuenta_Id", "dbo.Cuentas");
            DropForeignKey("dbo.Clientes", "Cuenta_Id", "dbo.Cuentas");
            DropIndex("dbo.RolCuentas", new[] { "Rol_Id" });
            DropIndex("dbo.RolCuentas", new[] { "Cuenta_Id" });
            DropIndex("dbo.Clientes", new[] { "Cuenta_Id" });
            DropTable("dbo.Rols");
            DropTable("dbo.RolCuentas");
            DropTable("dbo.RegistrarClientes");
            DropTable("dbo.Cuentas");
            DropTable("dbo.Clientes");
        }
    }
}

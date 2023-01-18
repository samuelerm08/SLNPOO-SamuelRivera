namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aviones",
                c => new
                    {
                        IdAvion = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Denominacion = c.String(nullable: false, maxLength: 50, unicode: false),
                        LineaAereaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdAvion)
                .ForeignKey("dbo.LineasAereas", t => t.LineaAereaId, cascadeDelete: true)
                .Index(t => t.LineaAereaId);
            
            CreateTable(
                "dbo.LineasAereas",
                c => new
                    {
                        IdLinea = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdLinea);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aviones", "LineaAereaId", "dbo.LineasAereas");
            DropIndex("dbo.Aviones", new[] { "LineaAereaId" });
            DropTable("dbo.LineasAereas");
            DropTable("dbo.Aviones");
        }
    }
}

namespace IDGS904ConBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alumnos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Apaterno = c.String(maxLength: 150),
                        Amaterno = c.String(maxLength: 150),
                        Edad = c.Int(nullable: false),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Maestroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Apaterno = c.String(maxLength: 150),
                        Amaterno = c.String(maxLength: 150),
                        Edad = c.Int(nullable: false),
                        Correo = c.String(),
                        Materia = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Maestroes");
            DropTable("dbo.Alumnoes");
        }
    }
}

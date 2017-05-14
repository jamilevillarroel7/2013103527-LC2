namespace _2013220746_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asientos",
                c => new
                    {
                        AsientoId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Cinturon_CinturonId = c.Int(),
                        Carro_CarroId = c.Int(),
                    })
                .PrimaryKey(t => t.AsientoId)
                .ForeignKey("dbo.Cinturones", t => t.Cinturon_CinturonId)
                .ForeignKey("dbo.Carros", t => t.Carro_CarroId)
                .Index(t => t.Cinturon_CinturonId)
                .Index(t => t.Carro_CarroId);
            
            CreateTable(
                "dbo.Cinturones",
                c => new
                    {
                        CinturonId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Metraje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinturonId);
            
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        CarroId = c.Int(nullable: false, identity: true),
                        TipoCarro = c.Int(nullable: false),
                        NumSerieChasis = c.String(),
                        Parabrisas_ParabrisasId = c.Int(),
                        Propietario_PropietarioId = c.Int(),
                        Volante_VolanteId = c.Int(),
                        Ensambladora_EnsambladoId = c.Int(),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Parabrisas", t => t.Parabrisas_ParabrisasId)
                .ForeignKey("dbo.Propietarios", t => t.Propietario_PropietarioId)
                .ForeignKey("dbo.Volantes", t => t.Volante_VolanteId)
                .ForeignKey("dbo.Ensamblados", t => t.Ensambladora_EnsambladoId)
                .Index(t => t.Parabrisas_ParabrisasId)
                .Index(t => t.Propietario_PropietarioId)
                .Index(t => t.Volante_VolanteId)
                .Index(t => t.Ensambladora_EnsambladoId);
            
            CreateTable(
                "dbo.Llantas",
                c => new
                    {
                        LlantaId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Carro_CarroId = c.Int(),
                    })
                .PrimaryKey(t => t.LlantaId)
                .ForeignKey("dbo.Carros", t => t.Carro_CarroId)
                .Index(t => t.Carro_CarroId);
            
            CreateTable(
                "dbo.Parabrisas",
                c => new
                    {
                        ParabrisasId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.ParabrisasId);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        PropietarioId = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        LicenciaConducir = c.String(),
                    })
                .PrimaryKey(t => t.PropietarioId);
            
            CreateTable(
                "dbo.Volantes",
                c => new
                    {
                        VolanteId = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.VolanteId);
            
            CreateTable(
                "dbo.Ensamblados",
                c => new
                    {
                        EnsambladoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EnsambladoId);
            
            CreateTable(
                "dbo.Automoviles",
                c => new
                    {
                        CarroId = c.Int(nullable: false),
                        TipoAuto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Carros", t => t.CarroId)
                .Index(t => t.CarroId);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        CarroId = c.Int(nullable: false),
                        TipoBus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarroId)
                .ForeignKey("dbo.Carros", t => t.CarroId)
                .Index(t => t.CarroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buses", "CarroId", "dbo.Carros");
            DropForeignKey("dbo.Automoviles", "CarroId", "dbo.Carros");
            DropForeignKey("dbo.Carros", "Ensambladora_EnsambladoId", "dbo.Ensamblados");
            DropForeignKey("dbo.Carros", "Volante_VolanteId", "dbo.Volantes");
            DropForeignKey("dbo.Carros", "Propietario_PropietarioId", "dbo.Propietarios");
            DropForeignKey("dbo.Carros", "Parabrisas_ParabrisasId", "dbo.Parabrisas");
            DropForeignKey("dbo.Llantas", "Carro_CarroId", "dbo.Carros");
            DropForeignKey("dbo.Asientos", "Carro_CarroId", "dbo.Carros");
            DropForeignKey("dbo.Asientos", "Cinturon_CinturonId", "dbo.Cinturones");
            DropIndex("dbo.Buses", new[] { "CarroId" });
            DropIndex("dbo.Automoviles", new[] { "CarroId" });
            DropIndex("dbo.Llantas", new[] { "Carro_CarroId" });
            DropIndex("dbo.Carros", new[] { "Ensambladora_EnsambladoId" });
            DropIndex("dbo.Carros", new[] { "Volante_VolanteId" });
            DropIndex("dbo.Carros", new[] { "Propietario_PropietarioId" });
            DropIndex("dbo.Carros", new[] { "Parabrisas_ParabrisasId" });
            DropIndex("dbo.Asientos", new[] { "Carro_CarroId" });
            DropIndex("dbo.Asientos", new[] { "Cinturon_CinturonId" });
            DropTable("dbo.Buses");
            DropTable("dbo.Automoviles");
            DropTable("dbo.Ensamblados");
            DropTable("dbo.Volantes");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Parabrisas");
            DropTable("dbo.Llantas");
            DropTable("dbo.Carros");
            DropTable("dbo.Cinturones");
            DropTable("dbo.Asientos");
        }
    }
}

namespace CU_Baseball_Stat_Modeler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FilledSeed : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Number = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Stats_Number = c.Int(),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Number)
                .ForeignKey("dbo.Stats", t => t.Stats_Number)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Stats_Number)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        Number = c.Int(nullable: false, identity: true),
                        BA = c.Double(nullable: false),
                        H = c.Int(nullable: false),
                        AB = c.Int(nullable: false),
                        HR = c.Int(nullable: false),
                        SO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Number);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rank = c.Int(nullable: false),
                        SchoolName = c.String(),
                        Mascot = c.String(),
                        NextGame = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Players", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Players", "Stats_Number", "dbo.Stats");
            DropIndex("dbo.Players", new[] { "Team_Id" });
            DropIndex("dbo.Players", new[] { "Stats_Number" });
            DropTable("dbo.Teams");
            DropTable("dbo.Stats");
            DropTable("dbo.Players");
        }
    }
}

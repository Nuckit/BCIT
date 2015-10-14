namespace Week5.Migrations.LocationMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Population = c.Int(nullable: false),
                        Province_Code = c.String(maxLength: 2),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.Province_Code)
                .Index(t => t.Province_Code);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 2),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Code);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Province_Code", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "Province_Code" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}

namespace Week5Home.Migrations.LocationsMigrations
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
                        ProvinceCode = c.String(maxLength: 2),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Provinces", t => t.ProvinceCode)
                .Index(t => t.ProvinceCode);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceCode = c.String(nullable: false, maxLength: 2),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ProvinceCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "ProvinceCode", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "ProvinceCode" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
        }
    }
}

namespace Week5Home.Migrations.LocationsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "CityName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Provinces", "ProvinceName", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Cities", "Name");
            DropColumn("dbo.Provinces", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Provinces", "Name", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Cities", "Name", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Provinces", "ProvinceName");
            DropColumn("dbo.Cities", "CityName");
        }
    }
}

namespace Week5.Migrations.LocationMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateNew : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "Province_Code", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "Province_Code" });
            AlterColumn("dbo.Cities", "Province_Code", c => c.String(nullable: false, maxLength: 2));
            CreateIndex("dbo.Cities", "Province_Code");
            AddForeignKey("dbo.Cities", "Province_Code", "dbo.Provinces", "Code", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Province_Code", "dbo.Provinces");
            DropIndex("dbo.Cities", new[] { "Province_Code" });
            AlterColumn("dbo.Cities", "Province_Code", c => c.String(maxLength: 2));
            CreateIndex("dbo.Cities", "Province_Code");
            AddForeignKey("dbo.Cities", "Province_Code", "dbo.Provinces", "Code");
        }
    }
}

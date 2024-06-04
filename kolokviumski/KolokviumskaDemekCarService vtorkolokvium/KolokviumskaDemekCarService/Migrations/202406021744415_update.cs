namespace KolokviumskaDemekCarService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "VIN", c => c.String());
            AlterColumn("dbo.Cars", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Name", c => c.String());
            DropColumn("dbo.Cars", "VIN");
        }
    }
}

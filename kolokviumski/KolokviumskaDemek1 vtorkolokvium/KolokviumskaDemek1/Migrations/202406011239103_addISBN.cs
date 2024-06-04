namespace KolokviumskaDemek1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addISBN : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "ISBN", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "Title", c => c.String());
            DropColumn("dbo.Books", "ISBN");
        }
    }
}

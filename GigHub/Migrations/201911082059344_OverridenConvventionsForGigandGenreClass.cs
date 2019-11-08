namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverridenConvventionsForGigandGenreClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Gigs", new[] { "Genre_ID" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Gigs", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Gigs", "ApplicationUser_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Gigs", "Genre_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Gigs", "ApplicationUser_Id");
            CreateIndex("dbo.Gigs", "Genre_ID");
            AddForeignKey("dbo.Gigs", "ApplicationUser_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres");
            DropForeignKey("dbo.Gigs", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "Genre_ID" });
            DropIndex("dbo.Gigs", new[] { "ApplicationUser_Id" });
            AlterColumn("dbo.Gigs", "Genre_ID", c => c.Int());
            AlterColumn("dbo.Gigs", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Gigs", "Venue", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.Gigs", "Genre_ID");
            CreateIndex("dbo.Gigs", "ApplicationUser_Id");
            AddForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres", "ID");
            AddForeignKey("dbo.Gigs", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}

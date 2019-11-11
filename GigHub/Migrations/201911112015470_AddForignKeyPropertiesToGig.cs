namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForignKeyPropertiesToGig : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_ID" });
            RenameColumn(table: "dbo.Gigs", name: "Artist_Id", newName: "ArtistId");
            RenameIndex(table: "dbo.Gigs", name: "IX_Artist_Id", newName: "IX_ArtistId");
            AddColumn("dbo.Gigs", "GenreId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Gigs", "Genre_ID", c => c.Int());
            CreateIndex("dbo.Gigs", "Genre_ID");
            AddForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_ID" });
            AlterColumn("dbo.Gigs", "Genre_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Gigs", "GenreId");
            RenameIndex(table: "dbo.Gigs", name: "IX_ArtistId", newName: "IX_Artist_Id");
            RenameColumn(table: "dbo.Gigs", name: "ArtistId", newName: "Artist_Id");
            CreateIndex("dbo.Gigs", "Genre_ID");
            AddForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres", "ID", cascadeDelete: true);
        }
    }
}

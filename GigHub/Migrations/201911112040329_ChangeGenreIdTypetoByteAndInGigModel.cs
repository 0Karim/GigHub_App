namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenreIdTypetoByteAndInGigModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_ID" });
            DropColumn("dbo.Gigs", "GenreId");
            RenameColumn(table: "dbo.Gigs", name: "Genre_ID", newName: "GenreId");
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "ID", c => c.Byte(nullable: false));
            AlterColumn("dbo.Gigs", "GenreId", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Genres", "ID");
            CreateIndex("dbo.Gigs", "GenreId");
            AddForeignKey("dbo.Gigs", "GenreId", "dbo.Genres", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "GenreId", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "GenreId" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Gigs", "GenreId", c => c.Int());
            AlterColumn("dbo.Genres", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Genres", "ID");
            RenameColumn(table: "dbo.Gigs", name: "GenreId", newName: "Genre_ID");
            AddColumn("dbo.Gigs", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Gigs", "Genre_ID");
            AddForeignKey("dbo.Gigs", "Genre_ID", "dbo.Genres", "ID");
        }
    }
}

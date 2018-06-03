namespace Dream_Getaway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_foreign_key : DbMigration
    {
        public override void Up()
        {
            AddColumn("Tours.Packages", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("Tours.Packages", "CategoryId");
            AddForeignKey("Tours.Packages", "CategoryId", "Tours.Categories", "CategoryId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Tours.Packages", "CategoryId", "Tours.Categories");
            DropIndex("Tours.Packages", new[] { "CategoryId" });
            DropColumn("Tours.Packages", "CategoryId");
        }
    }
}

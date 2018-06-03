namespace Dream_Getaway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_category_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tours.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropTable("Tours.Categories");
        }
    }
}

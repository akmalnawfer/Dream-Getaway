namespace Dream_Getaway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_column_Title : DbMigration
    {
        public override void Up()
        {
            AddColumn("Tours.Categories", "CategoryTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Tours.Categories", "CategoryTitle");
        }
    }
}

namespace Dream_Getaway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedcolumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("Tours.Categories", "CategoryTitle");
        }
        
        public override void Down()
        {
            AddColumn("Tours.Categories", "CategoryTitle", c => c.String());
        }
    }
}

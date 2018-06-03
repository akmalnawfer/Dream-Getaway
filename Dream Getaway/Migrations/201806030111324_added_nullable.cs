namespace Dream_Getaway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Tours.Packages", "NumberOfDays", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("Tours.Packages", "NumberOfDays", c => c.Int(nullable: false));
        }
    }
}

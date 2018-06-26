namespace Dream_Getaway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleted_nullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Tours.Packages", "PackageTitle", c => c.String());
            AlterColumn("Tours.Packages", "NumberOfDays", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("Tours.Packages", "NumberOfDays", c => c.Int());
            AlterColumn("Tours.Packages", "PackageTitle", c => c.String(nullable: false));
        }
    }
}

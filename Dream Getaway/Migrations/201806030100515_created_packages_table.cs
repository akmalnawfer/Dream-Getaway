namespace Dream_Getaway.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class created_packages_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Tours.Packages",
                c => new
                    {
                        PackageId = c.Int(nullable: false, identity: true),
                        PackageTitle = c.String(),
                        NumberOfDays = c.Int(nullable: false),
                        PackagePrice = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.PackageId);
            
        }
        
        public override void Down()
        {
            DropTable("Tours.Packages");
        }
    }
}

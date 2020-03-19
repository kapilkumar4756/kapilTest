namespace Jason_CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTable6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 100, storeType: "nvarchar"),
                        FirstName = c.String(maxLength: 250, storeType: "nvarchar"),
                        LastName = c.String(maxLength: 250, storeType: "nvarchar"),
                        Email = c.String(maxLength: 750, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}

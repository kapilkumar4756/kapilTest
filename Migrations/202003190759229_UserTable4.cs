namespace Jason_CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTable4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FirstName", c => c.String(unicode: false));
            AddColumn("dbo.Customers", "LastName", c => c.String(unicode: false));
            AddColumn("dbo.Customers", "Email", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "LastName");
            DropColumn("dbo.Customers", "FirstName");
        }
    }
}

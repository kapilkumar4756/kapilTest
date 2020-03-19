namespace Jason_CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTable3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(unicode: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(unicode: false));
            AddColumn("dbo.AspNetUsers", "DOB", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.AspNetUsers", "RegisteredOn", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.AspNetUsers", "IsApprovedbyAdmin", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "UserImage", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserImage");
            DropColumn("dbo.AspNetUsers", "IsApprovedbyAdmin");
            DropColumn("dbo.AspNetUsers", "RegisteredOn");
            DropColumn("dbo.AspNetUsers", "DOB");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}

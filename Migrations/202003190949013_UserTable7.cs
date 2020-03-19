namespace Jason_CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTable7 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "DOB");
            DropColumn("dbo.AspNetUsers", "RegisteredOn");
            DropColumn("dbo.AspNetUsers", "IsApprovedbyAdmin");
            DropColumn("dbo.AspNetUsers", "UserImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "UserImage", c => c.String(unicode: false));
            AddColumn("dbo.AspNetUsers", "IsApprovedbyAdmin", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "RegisteredOn", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.AspNetUsers", "DOB", c => c.DateTime(nullable: false, precision: 0));
        }
    }
}

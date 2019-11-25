namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Email", c => c.String());
            AddColumn("dbo.Todoes", "PhoneNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Todoes", "Salary", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Salary");
            DropColumn("dbo.Todoes", "PhoneNumber");
            DropColumn("dbo.Todoes", "Email");
        }
    }
}

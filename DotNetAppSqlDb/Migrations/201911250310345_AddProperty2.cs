namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Position", c => c.String());
            DropColumn("dbo.Todoes", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "Description", c => c.String());
            DropColumn("dbo.Todoes", "Position");
        }
    }
}

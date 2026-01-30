namespace Mvc_Project_Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addemailmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.students", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.students", "Email");
        }
    }
}

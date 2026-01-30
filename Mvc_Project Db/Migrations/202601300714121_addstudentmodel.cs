namespace Mvc_Project_Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstudentmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        city = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.students");
        }
    }
}

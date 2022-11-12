namespace CMD.Doctors.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        EmailId = c.String(nullable: false),
                        PhoneNo = c.String(nullable: false),
                        PracticeLocation = c.String(nullable: false),
                        Speciality = c.String(nullable: false),
                        NpiNo = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SignInDoctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        emailId = c.String(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SignInDoctors");
            DropTable("dbo.Doctors");
        }
    }
}

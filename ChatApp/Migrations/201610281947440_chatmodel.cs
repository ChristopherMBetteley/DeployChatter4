namespace ChatApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chatmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        ChatID = c.Int(nullable: false, identity: true),
                        ChatText = c.String(),
                        ChatTimeStamp = c.DateTime(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ChatID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chats", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Chats", new[] { "User_Id" });
            DropTable("dbo.Chats");
        }
    }
}

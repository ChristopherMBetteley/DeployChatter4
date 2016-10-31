namespace ChatApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FkeyGood : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Chats", name: "User_Id", newName: "Username_Id");
            RenameIndex(table: "dbo.Chats", name: "IX_User_Id", newName: "IX_Username_Id");
            AlterColumn("dbo.Chats", "ChatText", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Chats", "ChatText", c => c.String());
            RenameIndex(table: "dbo.Chats", name: "IX_Username_Id", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Chats", name: "Username_Id", newName: "User_Id");
        }
    }
}

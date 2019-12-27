namespace LDKJ.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Account = c.String(nullable: false, maxLength: 255, unicode: false),
                        Password = c.String(nullable: false, maxLength: 255, unicode: false),
                        NickName = c.String(nullable: false, maxLength: 255, unicode: false),
                        Photo = c.String(nullable: false, maxLength: 255, unicode: false),
                        RolesId = c.Int(nullable: false),
                        IsDisabled = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RolesId, cascadeDelete: true)
                .Index(t => t.RolesId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255, unicode: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdminsMenus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255, unicode: false),
                        Link = c.String(nullable: false, maxLength: 255, unicode: false),
                        ParentId = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AdminsPermissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RolesId = c.Int(nullable: false),
                        AdminsMenuId = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdminsMenus", t => t.AdminsMenuId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RolesId, cascadeDelete: true)
                .Index(t => t.RolesId)
                .Index(t => t.AdminsMenuId);
            
            CreateTable(
                "dbo.Copyrights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 255, unicode: false),
                        Detail = c.String(maxLength: 2000, unicode: false),
                        Email = c.String(maxLength: 255, unicode: false),
                        WeChat = c.String(maxLength: 255, unicode: false),
                        Logo = c.String(maxLength: 255, unicode: false),
                        Images = c.String(maxLength: 255, unicode: false),
                        QQ = c.String(maxLength: 255, unicode: false),
                        QQ1 = c.String(maxLength: 255, unicode: false),
                        Tel = c.String(maxLength: 255, unicode: false),
                        Tel1 = c.String(maxLength: 255, unicode: false),
                        Address = c.String(maxLength: 255, unicode: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255, unicode: false),
                        Keyword = c.String(nullable: false, maxLength: 255, unicode: false),
                        Description = c.String(nullable: false, maxLength: 255, unicode: false),
                        WebMenuId = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WebMenus", t => t.WebMenuId, cascadeDelete: true)
                .Index(t => t.WebMenuId);
            
            CreateTable(
                "dbo.WebMenus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255, unicode: false),
                        Link = c.String(nullable: false, maxLength: 255, unicode: false),
                        ParentId = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        UpDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seos", "WebMenuId", "dbo.WebMenus");
            DropForeignKey("dbo.AdminsPermissions", "RolesId", "dbo.Roles");
            DropForeignKey("dbo.AdminsPermissions", "AdminsMenuId", "dbo.AdminsMenus");
            DropForeignKey("dbo.Admins", "RolesId", "dbo.Roles");
            DropIndex("dbo.Seos", new[] { "WebMenuId" });
            DropIndex("dbo.AdminsPermissions", new[] { "AdminsMenuId" });
            DropIndex("dbo.AdminsPermissions", new[] { "RolesId" });
            DropIndex("dbo.Admins", new[] { "RolesId" });
            DropTable("dbo.WebMenus");
            DropTable("dbo.Seos");
            DropTable("dbo.Copyrights");
            DropTable("dbo.AdminsPermissions");
            DropTable("dbo.AdminsMenus");
            DropTable("dbo.Roles");
            DropTable("dbo.Admins");
        }
    }
}

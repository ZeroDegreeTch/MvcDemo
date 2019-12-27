namespace LDKJ.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LDKJ.Model.LD_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LDKJ.Model.LD_Context context)
        {
            Roles[] roles =  new Roles[]
            {
                new Roles{ Title = "超级管理员"},
                new Roles{ Title = "普通管理员"}
            };

            Admins[] admins = new Admins[]
            {
                new Admins(){Account = "admin",Password = "admin123.",NickName = "Genn",Photo = "Default.png",RolesId = 1}, 
            };


            AdminsMenu[] menus = new AdminsMenu[]
            {
                new AdminsMenu(){ Title = "系统管理",Link="#",ParentId = 0},
                new AdminsMenu(){ Title = "网站管理",Link="#",ParentId = 0},
                new AdminsMenu(){ Title = "优化管理",Link="#",ParentId = 0},
                new AdminsMenu(){ Title = "版权管理",Link="#",ParentId = 0},
                new AdminsMenu(){ Title = "权限设置",Link="#",ParentId = 1},
                new AdminsMenu(){ Title = "管理员设置",Link="#",ParentId = 1},
                new AdminsMenu(){ Title = "管理员菜单设置",Link="#",ParentId = 1},
                new AdminsMenu(){ Title = "管理员菜单权限设置",Link="#",ParentId = 1},
                new AdminsMenu(){ Title = "网站菜单设置",Link="#",ParentId = 2},
                new AdminsMenu(){ Title = "Seo优化设置",Link="#",ParentId = 3},
                new AdminsMenu(){ Title = "Copyright设置",Link="#",ParentId = 4}
            };


            context.Roles.AddOrUpdate(roles);
            context.SaveChanges();

            context.Admins.AddOrUpdate(admins);
            context.AdminsMenus.AddOrUpdate(menus);
            context.SaveChanges();

        }
    }
}

using System.Data.Entity;

namespace LDKJ.Model
{
    public class LD_Context : DbContext
    {
        public LD_Context()
        :base("name=DbCon")
        {
            
        }


        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<AdminsMenu> AdminsMenus { get; set; }
        public virtual DbSet<AdminsPermission> AdminsPermissions { get; set; }
        public virtual DbSet<WebMenu> WebMenus { get; set; }
        public virtual DbSet<Seo> Seos { get; set; }
        public virtual DbSet<Copyright> Copyrights { get; set; }


    }
}
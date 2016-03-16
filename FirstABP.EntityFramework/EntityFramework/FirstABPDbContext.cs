using Abp.EntityFramework;
using System.Data.Entity;

namespace FirstABP.EntityFramework
{
    public class FirstABPDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<FirstABP.Core.Entities.User> User { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public FirstABPDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in FirstABPDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of FirstABPDbContext since ABP automatically handles it.
         */
        public FirstABPDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}

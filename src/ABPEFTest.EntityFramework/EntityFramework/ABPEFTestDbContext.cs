using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using ABPEFTest.Authorization.Roles;
using ABPEFTest.Authorization.Users;
using ABPEFTest.Automotive;
using ABPEFTest.MultiTenancy;

namespace ABPEFTest.EntityFramework
{
    public class ABPEFTestDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        public virtual IDbSet<Make> Makes { get; set; }
        public virtual IDbSet<Model> Models { get; set; }
        public virtual IDbSet<Car> Cars { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABPEFTestDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPEFTestDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPEFTestDbContext since ABP automatically handles it.
         */
        public ABPEFTestDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABPEFTestDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABPEFTestDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}

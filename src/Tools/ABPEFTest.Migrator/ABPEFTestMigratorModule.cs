using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ABPEFTest.EntityFramework;

namespace ABPEFTest.Migrator
{
    [DependsOn(typeof(ABPEFTestDataModule))]
    public class ABPEFTestMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ABPEFTestDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
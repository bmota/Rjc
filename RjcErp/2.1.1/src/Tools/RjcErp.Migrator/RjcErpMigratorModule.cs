using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using RjcErp.EntityFramework;

namespace RjcErp.Migrator
{
    [DependsOn(typeof(RjcErpDataModule))]
    public class RjcErpMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<RjcErpDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
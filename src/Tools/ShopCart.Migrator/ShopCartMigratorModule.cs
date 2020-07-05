using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using ShopCart.EntityFramework;

namespace ShopCart.Migrator
{
    [DependsOn(typeof(ShopCartDataModule))]
    public class ShopCartMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<ShopCartDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
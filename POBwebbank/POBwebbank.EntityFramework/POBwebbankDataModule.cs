using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using POBwebbank.Core;

namespace POBwebbank.EntityFramwork {
    [DependsOn(typeof(AbpEntityFrameworkModule))]
    public class POBwebbankDataModule : AbpModule {
        public override void PreInitialize() {
            Database.SetInitializer(new CreateDatabaseIfNotExists<POBwebbankModel>());

            Configuration.DefaultNameOrConnectionString = "POBwebbankModel";
        }

        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

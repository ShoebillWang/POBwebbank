using System.Reflection;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Modules;
using Abp.Web.Mvc;
using Abp.Web.SignalR;
using POBwebbank.EntityFramwork;
using POBwebbank.Application;
using POBwebbank.Core;

namespace POBwebbank {
    [DependsOn(
       typeof(POBwebbankDataModule),
       typeof(POBwebbankApplicationModule),
       typeof(POBwebbankCoreModule),
       //typeof(AbpHangfireModule), - ENABLE TO USE HANGFIRE INSTEAD OF DEFAULT JOB MANAGER       
       typeof(AbpWebSignalRModule),
       typeof(AbpWebMvcModule))]
    public class POBwebbankWebModule : AbpModule {
        public override void PreInitialize() {
            //Enable database based localization
            //Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            ////Configure navigation/menu
            //Configuration.Navigation.Providers.Add<MVCABPNavigationProvider>();

            //Configure Hangfire - ENABLE TO USE HANGFIRE INSTEAD OF DEFAULT JOB MANAGER
            //Configuration.BackgroundJobs.UseHangfire(configuration =>
            //{
            //    configuration.GlobalConfiguration.UseSqlServerStorage("Default");
            //});
        }

        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //IocManager.IocContainer.Register(
            //    Component
            //        .For<IAuthenticationManager>()
            //        .UsingFactoryMethod(() => HttpContext.Current.GetOwinContext().Authentication)
            //        .LifestyleTransient()
            //);
            //IocManager.Register<IUserAppService, UserAppService>(DependencyLifeStyle.Transient);
            //IocManager.Register<ABPDataModel>();
            //IocManager.Register<IUserRepository, UserRepository>(DependencyLifeStyle.Transient);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
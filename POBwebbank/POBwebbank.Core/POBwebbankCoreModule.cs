using System.Reflection;
using Abp.Modules;

namespace POBwebbank.Core {
    //[DependsOn(typeof(AbpCoreModule))]
    public class MyMVCABPCoreModule : AbpModule {
        public override void PreInitialize() {
            //Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            //Configuration.Modules.Zero().EntityTypes.User = typeof(user);

            //Remove the following line to disable multi-tenancy.
            //Configuration.MultiTenancy.IsEnabled = MVCABPConsts.MultiTenancyEnabled;

            //Add/remove localization sources here
            //Configuration.Localization.Sources.Add(
            //    new DictionaryBasedLocalizationSource(
            //        MVCABPConsts.LocalizationSourceName,
            //        new XmlEmbeddedFileLocalizationDictionaryProvider(
            //            Assembly.GetExecutingAssembly(),
            //            "MVCABP.Localization.Source"
            //            )
            //        )
            //    );

            //AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            //Configuration.Authorization.Providers.Add<MVCABPAuthorizationProvider>();

            //Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
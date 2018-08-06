using Abp.AutoMapper;
using Abp.Modules;
using POBwebbank.Application.UserApp;
using System.Reflection;

namespace POBwebbank.Application {
    [DependsOn(typeof(AbpAutoMapperModule))]
    public class POBwebbankApplicationModule : AbpModule {
        public override void PreInitialize() {
            //使用module-zero实现的后台作业存储持久化后台作业到数据库
            IocManager.Register<IUserAppService, UserAppService>();
        }

        public override void Initialize() {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

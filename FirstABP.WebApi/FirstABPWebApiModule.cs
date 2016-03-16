using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace FirstABP
{
    [DependsOn(typeof(AbpWebApiModule), typeof(FirstABPApplicationModule))]
    public class FirstABPWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(FirstABPApplicationModule).Assembly, "app")
                .Build();
        }
    }
}

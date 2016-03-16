using System.Reflection;
using Abp.Modules;

namespace FirstABP
{
    [DependsOn(typeof(FirstABPCoreModule))]
    public class FirstABPApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

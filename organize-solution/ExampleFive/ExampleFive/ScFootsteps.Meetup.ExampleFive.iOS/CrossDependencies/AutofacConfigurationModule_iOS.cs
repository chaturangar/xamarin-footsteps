using ScFootsteps.Meetup.ExampleFive.Base;
using Autofac;
using ScFootsteps.Meetup.ExampleFive.CrossDependencies;

namespace ScFootsteps.Meetup.ExampleFive.iOS.CrossDependencies
{
    public class AutofacConfigurationModule_iOS : AutofacConfigurationModule
    {
        public override void RegisterPlatformSpecificDependencies(ContainerBuilder builder)
        {
            base.RegisterPlatformSpecificDependencies(builder);

            builder.RegisterType<SQLite_iOS>().As<ISQLite>();
        }
    }
}

using ScFootsteps.Meetup.ExampleFive.Base;
using ScFootsteps.Meetup.ExampleFive.CrossDependencies;
using Autofac;

namespace ScFootsteps.Meetup.ExampleFive.Droid.CrossDependencies
{
    public class AutofacConfigurationModule_Droid : AutofacConfigurationModule
    {
        public override void RegisterPlatformSpecificDependencies(ContainerBuilder builder)
        {
            base.RegisterPlatformSpecificDependencies(builder);

            builder.RegisterType<SQLite_Droid>().As<ISQLite>();
        }
    }
}
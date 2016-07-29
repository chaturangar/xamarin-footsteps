using Autofac;
using ScFootsteps.Meetup.ExampleFive.Repository;
using ScFootsteps.Meetup.ExampleFive.Services;

namespace ScFootsteps.Meetup.ExampleFive.Base
{
    public class AutofacConfigurationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Repository Layer
            builder.RegisterType<SqlRepository>().As<IDataRepository>().SingleInstance();

            // Service Layer
            builder.RegisterType<CalculationService>().As<ICalculationService>().SingleInstance();

            RegisterPlatformSpecificDependencies(builder);
        }

        public virtual void RegisterPlatformSpecificDependencies(ContainerBuilder builder)
        {

        }
    }
}

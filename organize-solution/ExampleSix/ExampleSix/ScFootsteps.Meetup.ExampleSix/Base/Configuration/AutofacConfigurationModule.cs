using Autofac;
using ScFootsteps.Meetup.ExampleSix.Repository;
using ScFootsteps.Meetup.ExampleSix.Services;

namespace ScFootsteps.Meetup.ExampleSix.Base.Configuration
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
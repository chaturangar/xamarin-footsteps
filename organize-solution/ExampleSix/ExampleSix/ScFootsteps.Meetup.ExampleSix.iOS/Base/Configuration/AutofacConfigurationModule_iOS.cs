using Autofac;
using ScFootsteps.Meetup.ExampleSix.Base.Configuration;
using ScFootsteps.Meetup.ExampleSix.Base.CrossDependencies;
using ScFootsteps.Meetup.ExampleSix.iOS.Base.CrossDependencies;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScFootsteps.Meetup.ExampleSix.iOS.Base.Configuration
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

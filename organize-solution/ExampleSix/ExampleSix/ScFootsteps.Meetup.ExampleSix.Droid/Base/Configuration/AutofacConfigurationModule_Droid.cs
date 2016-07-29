using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ScFootsteps.Meetup.ExampleSix.Base.Configuration;
using Autofac;
using ScFootsteps.Meetup.ExampleSix.Droid.Base.CrossDependencies;
using ScFootsteps.Meetup.ExampleSix.Base.CrossDependencies;

namespace ScFootsteps.Meetup.ExampleSix.Droid.Base.Configuration
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
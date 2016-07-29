using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ScFootsteps.Meetup.ExampleFive.Droid.CrossDependencies;

namespace ScFootsteps.Meetup.ExampleFive.Droid
{
    [Activity(Label = "ScFootsteps.Meetup.ExampleFive", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            global::Xamarin.Forms.Forms.Init(this, bundle);

            //Calling autofac
            App.Bootstraper(new AutofacConfigurationModule_Droid());

            LoadApplication(new App());
        }
    }
}


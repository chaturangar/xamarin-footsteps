using Autofac;
using ScFootsteps.Meetup.ExampleSix.Base.Configuration;
using ScFootsteps.Meetup.ExampleSix.Pages;

using Xamarin.Forms;

namespace ScFootsteps.Meetup.ExampleSix
{
    public class App : Application
    {
        public static IContainer Container { get; set; }

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static void Bootstraper(AutofacConfigurationModule autofacConfigs)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(autofacConfigs);
            Container = builder.Build();
        }
    }
}

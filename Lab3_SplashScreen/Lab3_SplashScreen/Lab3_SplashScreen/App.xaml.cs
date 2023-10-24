using Lab3_SplashScreen.Services;
using Lab3_SplashScreen.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3_SplashScreen
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

using System;
using FresiaApp.Pages;
using Xamarin.Forms;
using FreshMvvm;
using Xamarin.Forms.Xaml;
using FresiaApp.PageModels;

namespace FresiaApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);

            var page = FreshPageModelResolver.ResolvePageModel<DashboardPageModel>();

            var navigationPage = new FreshNavigationContainer(page);

            MainPage = navigationPage;
            //MainPage = new NavigationPage(new DashboardPage());
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

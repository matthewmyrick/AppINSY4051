using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppINSY4051.View;

namespace AppINSY4051
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomeView());
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

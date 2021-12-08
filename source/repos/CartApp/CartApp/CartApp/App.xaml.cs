using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CartApp.View;

namespace CartApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CategoryView();
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

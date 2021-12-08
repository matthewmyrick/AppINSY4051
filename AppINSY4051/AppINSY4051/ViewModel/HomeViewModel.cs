using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using AppINSY4051.View;
using System.Windows.Input;

namespace AppINSY4051.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        // property, constructur and method 
        public ICommand GoToAboutUsCommand { get; }

        public HomeViewModel()
        {
            GoToAboutUsCommand = new Command(GoToAboutUs);
        }


        private async void GoToAboutUs()
        {
            // there is an AboutUsViewModel(string message) Constructor as well. We can send 
            AboutUsViewModel aboutVM = new AboutUsViewModel();
            AboutUsView aboutV = new AboutUsView();
            aboutV.BindingContext = aboutVM;
            await Application.Current.MainPage.Navigation.PushAsync(aboutV);
        }
    }
}

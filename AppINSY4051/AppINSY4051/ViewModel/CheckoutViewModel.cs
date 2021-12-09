using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using AppINSY4051.Model;
using AppINSY4051.View;
using Xamarin.Forms;

namespace AppINSY4051.ViewModel
{
   public class CheckoutViewModel : BaseViewModel
    {
        private List<ShoppingCart> CheckoutList { get; set; }
        public ICommand CompleteCheckoutCommand { get; }
        public CheckoutViewModel()
        {
            CheckoutList = new List<ShoppingCart>();

            CompleteCheckoutCommand = new Command(CompleteCheckout);
        }

        private async void CompleteCheckout()
        {
            TransactionCompleteViewModel completeVM = new TransactionCompleteViewModel();
            TransactionCompleteView completeV = new TransactionCompleteView();
            completeV.BindingContext = completeVM;
            await Application.Current.MainPage.Navigation.PushAsync(completeV);
        }


    }




    public class ShoppingCart
    {

        List<Product> ShoppingCartItems { get; set; }
        List<Product> ShoppingCartPrice { get; set; }
    }

}

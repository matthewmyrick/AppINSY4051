using CartApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CartApp.ViewModel
{
   public class CategoryViewModel : BaseViewModel
    {
        private Product p1;
        private Product p2;
        private Product p3;
        public ProductCategory BooksCategory { get; }
        public List<string> Cart { get; set; }

        public ICommand AddToCartCommand { get; } // creates logic for add to cart button

        public CategoryViewModel()
        {
            p1 = new Product("1", "A Long Petal of the Sea: A Novel", "https://m.media-amazon.com/images/I/51TOIfPWbVL.jpg");
            p2 = new Product("2", "Stillhouse Lake", "https://m.media-amazon.com/images/I/41leYSjxbyL.jpg");
            p3 = new Product("3", "Information Systems", "https://google.com");
            BooksCategory = new ProductCategory("1", "Books");
            BooksCategory.Products.Add(p1);
            BooksCategory.Products.Add(p2);
            BooksCategory.Products.Add(p3);

            Cart = new List<string>();

            AddToCartCommand = new Command<string>(AddToCart); // creates command
        }

        private void AddToCart(string item)
        {
            Cart.Add(item);
            OnPropertyChanged(nameof(CartItems));
        }

        public ObservableCollection<string> CartItems
        {
            get
            {
                return new ObservableCollection<string>(Cart);
            }
        }
    }
}

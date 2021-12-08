using System;
using System.Collections.Generic;
using System.Text;

namespace AppINSY4051.ViewModel
{
    public class AboutUsViewModel : BaseViewModel
    {
        public string MessageFromBeyond { get; set; }
        public AboutUsViewModel() { }

        public AboutUsViewModel(string message)
        {
            MessageFromBeyond = message;
        }
    }
}

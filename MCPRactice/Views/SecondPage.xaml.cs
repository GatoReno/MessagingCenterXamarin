using System;
using System.Collections.Generic;
using MCPRactice.ViewModels;
using Xamarin.Forms;

namespace MCPRactice.Views
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            BindingContext = new SecondViewModel(Navigation);
        }
    }
}

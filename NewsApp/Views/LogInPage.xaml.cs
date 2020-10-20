using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_LoginTapped(object sender, EventArgs e)
        {
            loginStack.IsVisible = true;
            registerStack.IsVisible = false;
        }

        private void TapGestureRecognizer_RegisterTapped(object sender, EventArgs e)
        {
            registerStack.IsVisible = true;
            loginStack.IsVisible = false;
        }
    }
}
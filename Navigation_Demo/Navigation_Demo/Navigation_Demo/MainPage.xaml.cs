using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void ButtonModal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Seite2());
        }

        private async void ButtonNavigationPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Seite2());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RessourcenUndStyles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Style = (Style)Resources["specialButtonStyle2"];

            // Aus App.xaml:
            // App.Current.Resources
        }
    }
}

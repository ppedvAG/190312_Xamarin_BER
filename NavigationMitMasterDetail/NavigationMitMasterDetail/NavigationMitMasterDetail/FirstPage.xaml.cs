using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationMitMasterDetail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FirstPage : ContentPage
	{
		public FirstPage () 
        {
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            // NUR in einer NavigationPage
            Navigation.PushAsync(new SecondPage());
        }
    }
}
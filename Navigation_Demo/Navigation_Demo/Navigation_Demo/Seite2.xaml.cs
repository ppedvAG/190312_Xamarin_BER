using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Demo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Seite2 : ContentPage
	{
		public Seite2 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void ContentPage_Appearing(object sender, EventArgs e)
        {
            if (Navigation.ModalStack.Count == 0)
                buttonZurück.IsVisible = false;

            if(Device.Idiom == TargetIdiom.Tablet &&
               Device.RuntimePlatform == Device.iOS)
            {
                // Code nur für iPad
            }
        }
    }
}
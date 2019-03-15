using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPlugins
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertiesPage : ContentPage
    {
        public PropertiesPage()
        {
            InitializeComponent();
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            //var result  = await TextToSpeech.GetLocalesAsync();
            //listViewLocales.ItemsSource = result.ToList();
        }

        private void ContentPage_Disappearing(object sender, EventArgs e)
        {

        }
    }
}
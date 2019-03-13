using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Image_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Caching für heruntergeladene Bilder steuern
            //UriImageSource source = (UriImageSource)ImageSource.FromUri(new Uri("https://www.zooroyal.de/magazin/wp-content/uploads/2017/11/Goldhamster-760x560.jpg"));
            //source.CachingEnabled = true; // true ist bereits standardfall !
            //source.CacheValidity = TimeSpan.FromHours(1);
            //imageDemo.Source = source;

            // imageDemo.Source = ImageSource.FromFile("hamster.jpg");

            // RessurcenID: Projektname.Ordner.Dateiname.Extension
            // imageDemo.Source = ImageSource.FromResource("Image_Demo.Images.hamster.jpg");
        }
    }
}

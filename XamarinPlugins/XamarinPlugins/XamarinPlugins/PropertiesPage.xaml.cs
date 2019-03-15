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
            this.BindingContext = this;
        }

        private SpeechOptions currentOptions = new SpeechOptions();
         
        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            // Werte laden
            if (Application.Current.Properties.ContainsKey("Volume"))
                sliderVolume.Value = Convert.ToDouble(Application.Current.Properties["Volume"]);

            if(Application.Current.Properties.ContainsKey("Pitch"))
                sliderPitch.Value = Convert.ToDouble(Application.Current.Properties["Pitch"]);

            // Speaker laden

            var locales = await TextToSpeech.GetLocalesAsync();
            if (locales.Count() > 0)
                listViewSpeaker.ItemsSource = locales;
        }

        private void ContentPage_Disappearing(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "newSpeechOptions", currentOptions);

            // Werte für den nächten Programmstart speichern
            Application.Current.Properties["Volume"] = sliderVolume.Value;
            Application.Current.Properties["Pitch"] = sliderPitch.Value;
            Application.Current.SavePropertiesAsync();
        }

        private void SliderPitch_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            currentOptions.Pitch = Convert.ToSingle(e.NewValue);
        }

        private void SliderVolume_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            currentOptions.Volume = Convert.ToSingle(e.NewValue);
        }

        private void ListViewSpeaker_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            currentOptions.Locale = e.SelectedItem as Locale;
        }
    }
}
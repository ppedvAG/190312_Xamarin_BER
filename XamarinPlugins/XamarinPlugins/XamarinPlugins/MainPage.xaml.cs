using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamarinPlugins
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private Morse morse = new Morse();
        private async void ButtonTextToSpeech_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryInhalt.Text))
                await TextToSpeech.SpeakAsync(entryInhalt.Text);
        }

        private async void ButtonTextToMorse_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(entryInhalt.Text))
                await morse.MorseAusgeben(entryInhalt.Text);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            morse.Dauer = Convert.ToInt32(e.NewValue);
        }

        private void ButtonAbbrechen_Clicked(object sender, EventArgs e)
        {
            entryInhalt.Text = string.Empty;
            morse.Abbrechen();
        }
    }
}

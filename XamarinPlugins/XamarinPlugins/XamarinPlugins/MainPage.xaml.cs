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
            MessagingCenter.Subscribe<PropertiesPage, SpeechOptions>(this, "newSpeechOptions", SetSpechOptions);
            MessagingCenter.Subscribe<LogPage, string>(this, "Speak", SpeakText);
        }

        private async void SpeakText(LogPage arg1, string logText)
        {
            await TextToSpeech.SpeakAsync(logText, currentOptions);
        }

        private void SetSpechOptions(PropertiesPage sender, SpeechOptions newOptions)
        {
            currentOptions = newOptions;
        }

        private Morse morse = new Morse();
        private SpeechOptions currentOptions = new SpeechOptions();

        private async void ButtonTextToSpeech_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryInhalt.Text))
            {
                await TextToSpeech.SpeakAsync(entryInhalt.Text, currentOptions);
                if (await ((App)App.Current).Connection.Table<LogItem>().CountAsync(x => x.Text.Equals(entryInhalt.Text)) == 0)
                    await ((App)App.Current).Connection.InsertAsync(new LogItem { Text = entryInhalt.Text, Date = DateTime.Now });
            }
        }

        private async void ButtonTextToMorse_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(entryInhalt.Text))
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

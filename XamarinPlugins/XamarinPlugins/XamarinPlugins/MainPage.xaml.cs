﻿using System;
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
            await TextToSpeech.SpeakAsync(entryInhalt.Text);
        }

        private async void ButtonTextToMorse_Clicked(object sender, EventArgs e)
        {
            await morse.MorseAusgeben(entryInhalt.Text);
        }
    }
}

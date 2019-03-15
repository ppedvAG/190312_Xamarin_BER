﻿using System;
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
         
        private void ContentPage_Appearing(object sender, EventArgs e)
        {
        }

        private void ContentPage_Disappearing(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "newSpeechOptions", currentOptions);
        }

        private void SliderPitch_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            currentOptions.Pitch = Convert.ToSingle(e.NewValue);
        }

        private void SliderVolume_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            currentOptions.Volume = Convert.ToSingle(e.NewValue);
        }
    }
}
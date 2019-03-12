using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HalloXForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // "MessageBox"
            await DisplayAlert("Nachricht", "Hallo Welt", "Okay");

            // "Ja/Nein - MessageBox"
            bool result = await DisplayAlert("Frage", "Pause ?", "Ja", "Nein");
            await DisplayAlert("Antwort", $"Deine Antwort war: {result}", "Ok");

            // "Fallauswahl/Combobox - MessageBox"
            string obst = await DisplayActionSheet("Wähle dein Obst:", null, null, "Apfel", "Birne", "Banane","Orange");
            await DisplayAlert("Antwort", $"Deine Obst war: {obst}", "Ok");

            #region params
            //var erg1 = Add(12, 4);
            //erg1 = Add(12, 4, 8);
            //int[] werte = { 12, 4, 6, 7, 43, 21, 1 };
            //erg1 = Add(werte);

            //erg1 = Add(new int[] { 12, 1, 1, 1, 1 });
            //erg1 = Add(5, 5, 5, 5, 5, 5, 5, 5, 5, 5); 
            #endregion
        }

        #region params
        //public int Add(int zahl1, int zahl2)
        //{
        //    return zahl1 + zahl2;
        //}
        //public int Add(int zahl1, int zahl2, int zahl3)
        //{
        //    return zahl1 + zahl2 + zahl3;
        //}
        //public int Add(params int[] werte)
        //{
        //    return werte.Sum();
        //} 
        #endregion
    }
}

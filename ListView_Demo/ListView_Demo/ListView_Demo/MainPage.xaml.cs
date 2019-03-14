using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView_Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private ObservableCollection<Person> personen;

        private void LoadPersonen()
        {
            personen = new ObservableCollection<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=2000},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-300},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-1400},
                new Person{Vorname="Klara",Nachname="Fall",Alter=50,Kontostand=123123},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=60,Kontostand=-12321100},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=70,Kontostand=5555},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=80,Kontostand=99999},
                new Person{Vorname="Frank N",Nachname="Stein",Alter=90,Kontostand=1010101},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=100,Kontostand=-12345},
            };
        }

        private void ButtonPersonenLaden_Clicked(object sender, EventArgs e)
        {
            LoadPersonen();
            listViewPersonen.ItemsSource = personen;
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            LoadPersonen();
            listViewPersonen.ItemsSource = personen;

            // Variante 1
            // listViewPersonen.IsRefreshing = false;

            listViewPersonen.EndRefresh();
        }

        private void MenuItemInfo_Clicked(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            var person = (Person)item.BindingContext;

            listViewPersonen.SelectedItem = person;

            DisplayAlert("Info", $"{person.Vorname} {person.Nachname}", "Ok");
        }

        private void MenuItemDelete_Clicked(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            var person = (Person)item.BindingContext;

            personen.Remove(person);

            // Liste aktualisieren
            // Variante "hässlich"
            // listViewPersonen.ItemsSource = null; // reset
            // listViewPersonen.ItemsSource = personen; // neu setzen
        }

        private void SearchBarVoranme_TextChanged(object sender, TextChangedEventArgs e)
        {
            listViewPersonen.ItemsSource = personen.Where(x => x.Vorname.ToLower().Contains(e.NewTextValue.ToLower())).ToList();
        }
    }
}

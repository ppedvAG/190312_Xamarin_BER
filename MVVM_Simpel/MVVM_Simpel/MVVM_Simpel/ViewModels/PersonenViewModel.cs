using MVVM_Simpel.Domain;
using MVVM_Simpel.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace MVVM_Simpel.ViewModels
{
    public class PersonenViewModel : BaseViewModel
    {
        public PersonenViewModel()
        {
            GetPersonenCommand = new Command(GetPersonen);

            // Controllfreak-Antipattern
            service = new PersonenService();
        }

        private readonly PersonenService service;

        private void GetPersonen(object obj)
        {
            Personenliste = service.GetPersonen();
        }

        private List<Person> personenliste;
        public List<Person> Personenliste
        {
            get => personenliste;
            set => SetProperty(ref personenliste, value);
        }

        public Command GetPersonenCommand { get; set; }
    }
}

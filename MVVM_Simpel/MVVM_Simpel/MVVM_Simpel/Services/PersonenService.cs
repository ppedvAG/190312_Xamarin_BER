using MVVM_Simpel.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Simpel.Services
{
    public class PersonenService
    {
        public List<Person> GetPersonen()
        {
            return new List<Person>
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
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorisk_Oppgave_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.LagListe();
            Console.WriteLine("Skriv hjelp, liste eller vis+\"IDNummer\"");
            start:
            var ønske = Console.ReadLine().ToLower();

            if (ønske == "hjelp")
            {
                person.VisInfo();
            }

            if (ønske == "liste")
            {
                person.VisListe();
            }

            if (ønske.Contains("vis") && ønske.Any(char.IsDigit))
            {
                int sisteTall = Convert.ToInt32(ønske.Substring(ønske.Length - 1, 1));
                person.Show(sisteTall, true, true);
            }
            if (ønske != "hjelp" && ønske != "vis" && ønske != "liste")
            {
                Console.WriteLine("Prøv Igjen!");

            }
            goto start;
        }
    }

    public class Person

    {
        private int ID;
        private string FirstName;
        private string LastName;
        private Person Father;
        private Person Mother;
        private Person Child1;
        private Person Child2;
        private string BirthYear;
        private string DeathYear;

        
        private List<Person> _list = new List<Person>();



        public void VisInfo()
        {
            Console.WriteLine("Skriv Liste for å se alle personene.");
            Console.WriteLine("Skriv vis pluss ID nummer for å se en spesefikk person.");
            Console.WriteLine("OBS. Skriver du vis må det ikke være noe etter nummeret.");
        }


        public void LagListe()
        {
            var jaran = new Person { ID = 1, FirstName = "Jaran", LastName = "Bekhus", BirthYear = "1993", DeathYear = "TBA" };
            var oda = new Person { ID = 2, FirstName = "Oda", LastName = "Jonskås", BirthYear = "1992" };
            var aslak = new Person { ID = 3, FirstName = "Aslak", LastName = "Bekhus", BirthYear = "1955" };
            var aud = new Person { ID = 4, FirstName = "Aud", LastName = "Jonskås", BirthYear = "1957" };
            var jon = new Person { ID = 5, FirstName = "Jon", LastName = "Jonskås", DeathYear = "2007" };
            var kari = new Person { ID = 6, FirstName = "Kari", LastName = "Jonskås", DeathYear = "2011" };
            var augon = new Person { ID = 7, FirstName = "Augon", LastName = "Bekhus" };
            var tone = new Person { ID = 8, FirstName = "Tone", LastName = "Bekhus", DeathYear = "2019" };

            jaran.Father = aslak;
            jaran.Mother = aud;
            oda.Father = aslak;
            oda.Mother = aud;
            aslak.Father = augon;
            aslak.Mother = tone;
            aslak.Child1 = oda;
            aslak.Child2 = jaran;
            aud.Father = jon;
            aud.Mother = kari;
            aud.Child1 = oda;
            aud.Child2 = jaran;
            jon.Child1 = aud;
            kari.Child1 = aud;
            augon.Child1 = aslak;
            tone.Child1 = aslak;


            _list.Add(jaran);
            _list.Add(oda);
            _list.Add(aslak);
            _list.Add(aud);
            _list.Add(jon);
            _list.Add(kari);
            _list.Add(augon);
            _list.Add(tone);
        }
        public void VisListe()
        {
            for (int i = 0; i < _list.Count; i++)
            {
                Console.WriteLine("ID: " + _list[i].ID);
                if (_list[i].FirstName != null)
                {
                    Console.WriteLine("Fornavn: " + _list[i].FirstName);
                }
                if (_list[i].LastName != null)
                {
                    Console.WriteLine("Etternavn: " + _list[i].LastName);
                }
                if (_list[i].Father != null)
                {
                    Console.WriteLine("Far: " + _list[i].Father.FirstName + " ID: " + _list[i].Father.ID);
                }
                if (_list[i].Mother != null)
                {
                    Console.WriteLine("Mor: " + _list[i].Mother.FirstName + " ID: " + _list[i].Mother.ID);
                }
                if (_list[i].Child1 != null)
                {
                    Console.WriteLine("Barn: " + _list[i].Child1.FirstName + " ID: " + _list[i].Child1.ID);
                }
                if (_list[i].Child2 != null)
                {
                    Console.WriteLine("Barn: " + _list[i].Child2.FirstName + " ID: " + _list[i].Child2.ID);
                }
                if (_list[i].BirthYear != null)
                {
                    Console.WriteLine("Fødselsår: " + _list[i].BirthYear);
                }

                if (_list[i].DeathYear != null)
                {
                    Console.WriteLine("Dødsår: " + _list[i].DeathYear);
                }

                Console.WriteLine();
            }
        }
        public void Show(int sisteTall, bool onceF, bool onceM)
        {
            if (_list[sisteTall - 1].FirstName != null)
            {
                Console.WriteLine("Fornavn: " + _list[sisteTall - 1].FirstName);
            }
            if (_list[sisteTall - 1].LastName != null)
            {
                Console.WriteLine("Etternavn: " + _list[sisteTall - 1].LastName);
            }

            if (_list[sisteTall - 1].BirthYear != null)
            {
                Console.WriteLine("Fødselsår: " + _list[sisteTall - 1].BirthYear);
            }

            if (_list[sisteTall - 1].DeathYear != null)
            {
                Console.WriteLine("Dødsår: " + _list[sisteTall - 1].DeathYear);
            }

            if (_list[sisteTall - 1].Child1 != null)
            {
                Console.WriteLine("Barn: " + _list[sisteTall - 1].Child1.FirstName + " ID: " + _list[sisteTall - 1].Child1.ID);
            }
            if (_list[sisteTall - 1].Child2 != null)
            {
                Console.WriteLine("Barn: " + _list[sisteTall - 1].Child2.FirstName + " ID: " + _list[sisteTall - 1].Child2.ID);
            }

            if (_list[sisteTall - 1].Father != null)
            {
                Console.WriteLine("Far: " + _list[sisteTall - 1].Father.FirstName + " ID: " + _list[sisteTall - 1].Father.ID);
            }

            if (_list[sisteTall - 1].Mother != null)
            {
                Console.WriteLine("Mor: " + _list[sisteTall - 1].Mother.FirstName + " ID: " + _list[sisteTall - 1].Mother.ID);
            }

            while (onceF == true)
            {
                onceF = false;
                Console.WriteLine();
                Show(_list[sisteTall - 1].Father.ID, false, false);
            }
            while (onceM == true)
            {
                onceM = false;
                Console.WriteLine();
                Show(_list[sisteTall - 1].Mother.ID, false, false);
            }
        }


    }

}


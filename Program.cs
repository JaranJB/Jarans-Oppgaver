﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Obligatorisk_Oppgave_1
{
    public class Program
    {


        static void Main(string[] args)
        {

            List<Person> _list = new List<Person>();
            LagListe(_list);
            Console.WriteLine("Skriv hjelp, liste eller vis+\"IDNummer\"");
            start:
            var ønske = Console.ReadLine().ToLower();

            if (ønske == "hjelp")
            {
                VisInfo();
            }

            if (ønske == "liste")
            {
                foreach (var person in _list)
                {
                    person.Show();
                }
            }

            if (ønske.Contains("vis") && ønske.Any(char.IsDigit))
            {
                int sisteTall = Convert.ToInt32(ønske.Substring(ønske.Length - 1, 1));
                var person = _list[sisteTall - 1];
                person.Show();
                var parent1 = person.Father;
                var parent2 = person.Mother;
                if (parent1 != null) parent1.Show();
                if (parent2 != null) parent2.Show();
                foreach (var one in _list)
                {
                    if (one.Father == person) one.Show();
                    if (one.Mother == person) one.Show();
                }
            }
            if (ønske != "hjelp" && ønske != "vis" && ønske != "liste")
            {
                Console.WriteLine("Prøv Igjen!");

            }
            goto start;
        }
        public static void VisInfo()
        {
            Console.WriteLine("Skriv Liste for å se alle personene.");
            Console.WriteLine("Skriv vis pluss ID nummer for å se en spesefikk person.");
            Console.WriteLine("OBS. Skriver du vis må det ikke være noe etter nummeret.");
        }

        public static void LagListe(List<Person> _list)
        {
            var jaran = new Person { ID = 1, FirstName = "Jaran", LastName = "Bekhus", BirthYear = "1993" };
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
            aud.Father = jon;
            aud.Mother = kari;


            _list.Add(jaran);
            _list.Add(oda);
            _list.Add(aslak);
            _list.Add(aud);
            _list.Add(jon);
            _list.Add(kari);
            _list.Add(augon);
            _list.Add(tone);
        }





    }


}

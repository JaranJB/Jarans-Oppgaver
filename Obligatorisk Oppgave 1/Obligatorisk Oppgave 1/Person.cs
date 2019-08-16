using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;

namespace Obligatorisk_Oppgave_1
{
    public class Person
    {


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string BirthYear { get; set; }
        public string DeathYear { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }

        public void Show()
        {
            Console.WriteLine("ID: " + ID);
            if (FirstName != null) Console.WriteLine("Fornavn: " + FirstName);
            if (LastName != null) Console.WriteLine("Etternavn: " + LastName);
            if (BirthYear != null) Console.WriteLine("Fødselsår: " + BirthYear);
            if (DeathYear != null) Console.WriteLine("Dødsår: " + DeathYear);
            if (Father != null) Console.WriteLine("Far: " + Father.FirstName);
            if (Mother != null) Console.WriteLine("Mor: " + Mother.FirstName);
            Console.WriteLine();
        }
    }
}
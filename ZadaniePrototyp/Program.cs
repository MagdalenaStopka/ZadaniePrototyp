using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePrototyp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Roman";
            person.LastName = "Kowalski";
            person.IsWoman = false;
            person.BirthDate = new DateTime(2000, 1, 1); 
            var cloned = (Person)person.Clone();
            cloned.FirstName= "Krzysztof";
            Console.WriteLine(person);
            Console.WriteLine(cloned);
            //Wynik RomanEmployee
            //Imię: Roman, Nazwisko: Kowalski, Płeć: M, Data urodzenia 01.01.2000
            //Imię: Krzysztof, Nazwisko: Kowalski, Płeć: M, Data urodzenia 01.01.2000
            Console.WriteLine("Zadanie bonusowe:");
            Person defaultPerson = new Person();
            Console.WriteLine(defaultPerson);
            //Wynik
            //Imię: Kazimierz, Nazwisko: Nowak, Płeć: M, Data urodzenia 01.02.1950
            Console.ReadKey();
        }
    }
}

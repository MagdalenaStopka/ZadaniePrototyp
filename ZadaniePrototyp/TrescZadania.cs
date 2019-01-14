using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePrototyp
{
    class TrescZadania
    {
       /* Wstęp:
W aplikacjach aby nie uzupełniać wszystkich właściwości przy każdym tworzeniu obiektu stosuje się klonowanie.Jest to tworzenie obiektów na podstawie prototypu co ma na celu stworzenie obiektu z wypełnionymi danymi domyślnymi.
Opis działania aplikacji do „klonowania ludzi”:
Zadanie:
Utwórz aplikację w której można tworzyć klony za pomocą klasy Person.Klasa person przez metodę Clone() ma zwracać kopię samego siebie. Ma posiadać przesłoniętą metodę ToString() aby ładnie formatować informacje o obiekcie przy wyświetlaniu informacji.
Bonus:
Zmień tak klasę Person aby pobierała domyślne wartości dla swoich właściwości z App.config podczas tworzenia obiektu (z sekcji appSettings). Umożliwi to wyświetlanie danych domyślnych od razu po utworzeniu nowego obiektu.
Kod metody Main:
static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Roman";
            person.LastName = "Kowalski";
            person.IsWoman = false;
            person.BirthDate = new DateTime(2000, 1, 1);
            var cloned = person.Clone();
            cloned.FirstName = "Krzysztof";
            Console.WriteLine(person);
            Console.WriteLine(cloned);
            //Wynik RomanEmployee
            //Imię: Roman, Nazwisko: Kowalski, Płeć: M, Data urodzenia 01.01.2000
            //Imię: Krzysztof, Nazwisko: Kowalski, Płeć: M, Data urodzenia 01.01.2000
            //Bonus
            Person defaultPerson = new Person();
            Console.WriteLine(defaultPerson);
            //Wynik
            //Imię: Kazimierz, Nazwisko: Nowak, Płeć: M, Data urodzenia 01.02.1950
            Console.Read();
        }
        */
    }
}

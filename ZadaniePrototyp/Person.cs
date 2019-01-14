using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniePrototyp
{
    class Person : ICloneable
    {
        public string FirstName = System.Configuration.ConfigurationManager.AppSettings["FirstName"];
        public string LastName = System.Configuration.ConfigurationManager.AppSettings["LastName"];
        public DateTime BirthDate =DateTime.Parse( System.Configuration.ConfigurationManager.AppSettings["BirthDate"]);
        public bool IsWoman { get; set; }
       
        public override string ToString()
        {
            return string.Format("Imię:{0}, Nazwisko: {1}, Płeć: {2}, Data urodzenia:{3}", FirstName, LastName, IsWoman ? "K": "M", BirthDate.ToShortDateString());
        }
        public Object Clone()
        {
            var person = (Person)MemberwiseClone();
            return person;
        }
    }
}

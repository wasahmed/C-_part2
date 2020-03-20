using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP2
{
    public class Person1
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    class AccessModifiers
    {
        static void Main(string[] args)
        {
            var person = new Person1();
            person.SetBirthdate(new DateTime(1999, 1, 2));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}

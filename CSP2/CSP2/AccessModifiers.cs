using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP2
{
    public class Person1
    {
        //private DateTime _birthdate;

        //public void SetBirthdate(DateTime birthdate)
        //{
        //    _birthdate = birthdate;
        //}
        //public DateTime GetBirthdate()
        //{
        //    return _birthdate;
        //}
        //OR
        //public DateTime Birthdate
        //{
        //    get { return _birthdate; }
        //    set { _birthdate = value; }
        //}
        //OR
        public Person1(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public DateTime Birthdate { get; private set; }
        public int Age
        {//some logic needed so not autoimplemented
            get {
                var ts =DateTime.Today - Birthdate;
                var years = ts.Days / 365;

                return years;
            }
        }
    }
    class AccessModifiers
    {
        //static void Main(string[] args)
        //{
        //    //var person = new Person1();
        //    //person.SetBirthdate(new DateTime(1999, 1, 2));
        //    //Console.WriteLine(person.GetBirthdate());

        //    var person = new Person1(new DateTime(1982, 1, 1));
        //    Console.WriteLine(person.Age);

        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP2
{
    public class Person //blueprint from which we can create onjects
    {
        public string Name;//data//fields/attributes

        public void Introduce(string to)//behaviour//methods
        {
            Console.WriteLine("Hi " + to);
            //format string?
        }

        //public static Person Parse(string str)
        //{
        //    var person = new Person();
        //    person.Name = str;
        //    return person; //object
        //}
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //var person = new Person();
    //        //person.Introduce("john");

    //        var customer = new Customer(1, "joe");//object - instance of class
    //        ////with no constructor
    //        //customer.Id = 2;
    //        //customer.Name = "jack";
    //       // Console.WriteLine(customer.Id);
    //       // Console.WriteLine(customer.Name);

    //    }
    //}
}
//"this" references the current object
//constructor overloading 
    //-to make initialization easier(different ones used at different times)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP2
{
   
    class Methods
    {
        //static void Main(string[] args)
        //{
        //    var customer = new Customer2(2);
        //    customer.Orders.Add(new Order1());
        //    //customer.Promote();
        //    Console.WriteLine(customer.Orders.Count);      
        //}

        static void UseOut()
        {
            //var number = int.Parse("abc");
            //use try catch with int.Parse
            //int number;
            //var result = int.TryParse("abc", out number);
            //if (result)
            //    Console.WriteLine(number);
            //else
            //    Console.WriteLine("failed ");
            UseParams();
        }

        static void UseParams()
        {
            //effect of using params modifier
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11));
            Console.WriteLine(calculator.Add(new int[] { 5, 5 }));

        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                //point.Move(new Point(40,60));//took a point object
                point.Move(null);
                Console.WriteLine("point is at " + point.X + "X " + point.Y + "Y");

                point.Move(100, 200);
                Console.WriteLine("point is at " + point.X + "X " + point.Y + "Y");


            }
            catch (Exception)
            {
                Console.WriteLine("unexpected error");
            }
        }
    }
}

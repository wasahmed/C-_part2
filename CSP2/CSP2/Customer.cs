using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP2
{
    public class Customer
    {
        public int Id;//real world access modifier would probably not be public
        public string Name;
        public List<Order> Orders;
        //default constructor
        public Customer()
        {
            Orders = new List<Order>();//initialise to an empty list - best practice else it will give an error NULL error exception
        }
        public Customer(int id)
            : this()//calls the default constructor so we get the initialised list without having to copy it to each of the constructor overloads
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            :this(id)
        {
            //this.Id = id; //dont need this line because of this(id)
            this.Name = name;
        }
    }
}

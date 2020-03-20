using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP2
{
    class Customer2
    {
        public int Id;
        public string Name;
        public readonly List<Order1> Orders = new List<Order1>();//initialised here rather than in the default constructor
        //readonly so it cannot be reset
        public Customer2(int id)
        {
            this.Id = id;
        }

        public Customer2(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order1>();//this would reset our list
        }
    }

    public class Order1
    {

    }
}

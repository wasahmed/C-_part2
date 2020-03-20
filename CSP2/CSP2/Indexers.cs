//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSP2
//{
//    class Indexers
//    {
//        public class HttpCookie
//        {
//            private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
//            public string this[string key]
//            {
//                get { return _dictionary[key]; }
//                set { _dictionary[value] = value; }
//            }
//        }
//        static void Main(string[] args)
//        {
//            var cookie = new HttpCookie();
//            cookie["name"] = "x";
//            Console.WriteLine(cookie["name"]);
//        }
//    }
//}

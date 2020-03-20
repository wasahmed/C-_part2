//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSP2
//{
//    //public DateTime Birthdate { get; private set; }
//    //public int Age
//    //{//some logic needed so not autoimplemented
//    //    get
//    //    {
//    //        var ts = DateTime.Today - Birthdate;
//    //        var years = ts.Days / 365;

//    //        return years;
//    //    }
//    //public class StopWatch
//    //{
//    //    public DateTime Start()
//    //    {
//    //        var strt = DateTime.Now;
//    //        return strt;
//    //    }
//    //    //private DateTime _startTime;
//    //    //private DateTime _stopTime;

//    //    public DateTime Stop()
//    //    {
//    //        var stp = DateTime.Now;
//    //        return stp;
//    //    }

//    //    public TimeSpan duration
//    //    {
//    //       get{ return Stop() - Start(); }
//    //    }
//    //}
//    public class StopWatch
//    {
//        private DateTime _startTime;
//        private DateTime _stopTime;
//        private bool _started = false;

//        public TimeSpan Duration
//        {
//            get { return _stopTime - _startTime; }
//        }

//        public void Start()
//        {
//            if (_started == false)
//            {
//                _startTime = DateTime.Now;
//                _started = true;
//            }

//            else
//                throw new InvalidOperationException();
//        }

//        public void Stop()
//        {
//            _stopTime = DateTime.Now;
//            _started = false;
//        }
//    }
//    class TestProgram
//    {
//        static void Main(string[] args)
//        {
//            var watch = new StopWatch();
//            while (true)
//            {
//                Console.WriteLine("Enter command: ");
//                var command = Console.ReadLine();

//                if(command.ToLower() == "start")
//                {
//                    watch.Start();
//                    //Console.WriteLine(watch.Start().);
//                }
//                else if (command.ToLower() == "stop")
//                {
//                    watch.Stop();
//                    //Console.WriteLine(y.ToString());
//                }
//                else if (command.ToLower() == "duration")
//                {
//                    var z = watch.Duration;
//                    Console.WriteLine(z.Seconds);
//                }
//            }
//        }
//    }
//}

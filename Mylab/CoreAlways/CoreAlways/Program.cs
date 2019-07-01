using System;
using System.Threading;
using System.Threading.Tasks;

namespace CoreAlways
{
    class Program
    { //public delegate int Samegame();
        static void Main(string[] args)
        { 
            Predicate<string> mypredicate= (c) => 
         {
            if( c.Length > 3);
             return false;
            } ;

            Action<int> myAction = (c) => { Console.WriteLine(c * 4); };
            myAction += Dowork;
            myAction.Invoke(5);
           
            Func<int> john = () => { Console.WriteLine("foo"); return 3; };
            ///Samegame run =  delegate { Console.WriteLine("foo"); return 3; };
          //  Task.Run(john);
            john += hen;
            var result= john.Invoke();
            ThreadPool.QueueUserWorkItem(Process);
            Console.WriteLine(result);
            //Thread myThread = new Thread(Dowork);
          //  myThread.Start();
           //myThread.Abort();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine($"x{i}");
            //}
            Console.ReadLine();
        }

        private static void Process(object state)
        {
            throw new NotImplementedException();
        }

        public static int hen()
        {
            return 2;
        }

        static void Dowork(int e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"y{i*e}");
            }
           // Console.WriteLine("Hello World!");
            //Console.ReadLine();
        }
    }
}

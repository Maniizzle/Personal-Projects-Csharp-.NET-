partial class Program
    {
        static void Maink(string[] args)
        {
            Thread myThread = new Thread(Dowork);
            myThread.Start();
            myThread.Abort();
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"x{i}");
            }
            Console.ReadLine();
        }
        static void Dowork()
        {
            for (int i=0; i < 1000; i++)
            {
                Console.WriteLine($"y{i}");
            }
        }
    }
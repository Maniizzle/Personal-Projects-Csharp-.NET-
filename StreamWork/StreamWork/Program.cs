using System;
using System.IO;

namespace StreamWork
{
    class Program
    {
        static void Main(string[] args)

        {
            using (FileStream fs = new FileStream(@"c:\files\data.txt", FileMode.Create, FileAccess.Write))
            {
                fs.WriteByte(100);
                fs.Position = 0; 

            }
            Console.WriteLine("Done");
            Console.ReadLine();




            Console.WriteLine("Hello World!");
        }

            //using (FileStream fs = File.Create(@"C:\Users\OLAMIDE ONAKOYA\source\repos\testfile.txt")) 
            //{
            //    //position is 0
            //    long pos = fs.Position;

            //    //sets the position to 1
            //    fs.Position = 1;
            //    byte[] arrbytes = { 100, 101,200,30,56,34,25,65,78 };
            //    //writes the content of arrbytes into current position. which is 1
            //    fs.Write(arrbytes, 0, arrbytes.Length);
            //    //position is now 3 as its advanced by write 
            //    pos = fs.Position;

            //    fs.Position = 10;
            //    byte[] dataToRead = new byte[fs.Length];
            //    int bytesRead = fs.Read(dataToRead, 0, dataToRead.Length);
            //    Console.WriteLine(bytesRead);
            //    foreach (var item in dataToRead)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.ReadLine();

                //byte[] readdata1 = ReadBytes(fs);
                //foreach (var item in readdata1)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.ReadLine();

            }
        }

        private static byte[] ReadBytes(Stream stream)
        {
            //dataToRead will hold the data read from the stream
            byte[] dataToRead = new byte[stream.Length];

            //this is the total numer of bytes read. this will be invremented
            //and eventually will equal the bytes size held by the stream

            int totalBytesRead = 0;

            //this is the number of bytes read in each iteration(i.e chunksize)
            int chunkBytesRead = 1;

            while (totalBytesRead < dataToRead.Length && chunkBytesRead > 0)
            {
                chunkBytesRead = stream.Read(dataToRead, totalBytesRead, dataToRead.Length - totalBytesRead);
                totalBytesRead = totalBytesRead + chunkBytesRead;
            }
            return dataToRead;
            //
            //throw new NotImplementedException();
        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;

namespace LoadingBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 30);
            //if (args.Length != 0)
            //    foreach (string s in args)
            //    {
            //        Console.WriteLine(s);
            //    }
            //else
            //    Console.WriteLine("no args");
            string a = args[0];
            string[] str = a.Split(',');
            Console.BufferWidth = Convert.ToInt32(str[0]);
            Console.BufferHeight = Convert.ToInt32(str[1]);
            Console.SetWindowPosition(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]);
            //Console.MoveBufferArea(0, 0, Console.BufferWidth, Console.BufferHeight, 10, 10);
            Task.Run(() => Method1()).Wait();
            Console.Read();
        }

        static void Method1()
        {

            Console.WriteLine("\n\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("|");
                Thread.Sleep(500);
            }
            Environment.Exit(0);
        }
    }
}
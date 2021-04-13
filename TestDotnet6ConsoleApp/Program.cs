using System;
using System.Threading;

namespace TestDotnet6ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Running {typeof(string).Assembly.Location}");
            Thread.Sleep(10000);
        }
    }
}

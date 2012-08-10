using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using ConsoleApplicationClient.ServiceReference2;

namespace ConsoleApplicationClient
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.Sleep(1000);
            using (MyCalculatorTestClient proxy = new MyCalculatorTestClient())
            {
                double a = 123;
                double b = 443;
                Console.WriteLine("{0}+{1}={2}", a, b, proxy.Add(a, b));
                Console.Read();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine('b');

            //Console.WriteLine(0.25F);

            //Console.WriteLine(2.625);

            //Console.WriteLine(12.39816m);

            //Console.WriteLine(true);
            //Console.WriteLine(false);

            //Console.WriteLine("123");
            //Console.WriteLine(123);

            //Console.WriteLine("true");
            //Console.WriteLine(true);

            //string firstName;
            //firstName = "Bob";
            //Console.WriteLine(firstName);
            //firstName = "Liem";
            //Console.WriteLine(firstName);
            //firstName = "Isabella";
            //Console.WriteLine(firstName);
            //firstName = "Yasmin";
            //Console.WriteLine(firstName);

            //var message = "Hello World!";

            // Desafio
            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.WriteLine($"Hello, {name}! You have {messages} messages in your inbox. The temperature is {temperature} celsius.");

            Console.ReadKey();
        }
    }
}

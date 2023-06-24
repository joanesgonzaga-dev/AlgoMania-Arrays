using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoMania_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 9.7, 3.1, 1.2, 4.7, 15.00,15.00,15.00,15.00,6.5, 8.0, 0.0, 2.01, 5.8, 7.9, 8.0 };

            Console.Write("{");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(String.Format(new CultureInfo("en-US"), "{0:0.00}", numbers[i]) + (i < numbers.Length - 1 ? "," : ""));
            }

            Console.Write("}");
            Console.WriteLine();

            double d = numbers.ReturnsRepeater<double>();

            Console.WriteLine("No Array acima, o elemento que mais se repete é: " + String.Format(new CultureInfo("en-US"), "{0:0.00}", d));
            Console.Read();
        }

        private static void RemoveItems()
        {
            double[] numbers = new double[] { 9.7, 3.1, 1.2, 4.7, 6.5, 8.0, 0.0, 2.01, 5.8, 7.9, 8.0 };
            Array.Sort(numbers);
            numbers[3] = 12;

            var _app = numbers.Append<double>(50.4);

            numbers.RemoveFirstEquals<double>(8.0, ref numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < _app.Count(); i++)
            {
                Console.WriteLine(_app.ElementAt(i));
            }
        }
    }
}

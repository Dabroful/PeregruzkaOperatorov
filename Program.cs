using System;
using System.Globalization;

namespace PeregruzkaOperatorov
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Poroda vyatskaya = new Poroda("Вятская", 350, 1);
            Poroda yakutskaya = new Poroda("Якутская", 500, 2);

            var Telega1 = Poroda.Add(vyatskaya, yakutskaya);
            var Telega2 = vyatskaya + yakutskaya;
            
            Console.WriteLine(vyatskaya);
            Console.WriteLine(yakutskaya);
            Console.WriteLine(Telega1);
            Console.WriteLine(Telega2);

            Console.ReadLine();
        }
    }
}

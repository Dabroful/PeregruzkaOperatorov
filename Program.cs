using System;
using System.Globalization;

namespace PeregruzkaOperatorov
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Apple apple = new Apple("красное яблоко", 100, 100);
            Apple apple2 = new Apple("зеленое яблоко", 90, 110);

            var sumApple = Apple.Add(apple, apple2);
            var sumApple2 = apple + apple2;
            
            Console.WriteLine(apple);
            Console.WriteLine(apple2);
            Console.WriteLine(sumApple);
            Console.WriteLine(sumApple2);

            Console.ReadLine();
        }
    }
}
namespace PeregruzkaOperatorov
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Apple apple = new Apple("красное яблоко", 100, 100);
            Apple apple2 = new Apple("зеленое яблоко", 90, 110);

            //весь смысл перегрузки операоров в том, чтобы сложить два класса в один. Ниже это и происходит.
            var sumApple = Apple.Add(apple, apple2);
            var sumApple2 = apple + apple2;
        }
    }
}
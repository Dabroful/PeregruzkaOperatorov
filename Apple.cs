using System;

namespace PeregruzkaOperatorov
{
    //новый класс, наследуемый от product
    public class Apple : Product
    {
        //в классе наследника обязательно должен быть конструктор с такими же параметрами, как у родителя
        public Apple(string name, int calorie, int volume) : base(name, calorie, volume)
        {
            
        }

        //складываем двав яблока
        public static Apple Add(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);
            return apple;
        }

        public static Apple operator +(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);
            return apple;
        }
    }
}
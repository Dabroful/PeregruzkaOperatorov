using System;

namespace PeregruzkaOperatorov
{
    //создаем общий класс для всех продуктов
    public abstract class Product
    {
        //объявляем свойства класса
        public string Name { get; }
        public int Calorie { get; }
        public int Volume { get; set; }

        public double Energy
        {
            get
            {
                return Volume * Calorie / 100;
            }
        }
        
        //заставим всех наследников реализовывать конкретные конструкторы
        public Product(string name, int calorie, int volume)
        {
            //проверяем входны данные на правильность
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (calorie <= 0)
            {
                throw new ArgumentException(nameof(calorie));
            }
            if (volume < 0)
            {
                throw new ArgumentException(nameof(volume));
            }

            Name = name;
            Calorie = calorie;
            Volume = volume;
        }

        public override string ToString()
        {
            return $"{Name}. Каллорийность: {Calorie}, объем {Volume} ";
        }
    }
}
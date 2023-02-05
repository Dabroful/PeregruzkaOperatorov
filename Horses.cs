using System;

namespace PeregruzkaOperatorov
{
    public class Horses
    {
        public string Name { get; }
        public int Mass { get; set; }
        public int Power { get; set; }

        public Horses(string name, int mass, int power)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (mass < 100)
            {
                throw new ArgumentException(nameof(mass));
            }

            if (power < 1)
            {
                throw new ArgumentException(nameof(power));
            }

            Name = name;
            Mass = mass;
            Power = power;
        }

        public override string ToString()
        {
            return $"Упряжка {Name} силой {Power}, массой {Mass}";
        }
    }
}

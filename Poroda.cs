namespace PeregruzkaOperatorov
{
    public class Poroda : Horses
    {
        public Poroda(string name, int mass, int power) : base(name, mass, power)
        {
        }

        public static Poroda Add(Poroda horse1, Poroda horse2)
        {
            int massOfTelega = horse1.Mass + horse2.Mass;
            int powerOfTelega = horse1.Power + horse2.Power;
            var Horse = new Poroda("Лошадь", massOfTelega, powerOfTelega);
            return Horse;
        }

        public static Poroda operator +(Poroda horse1, Poroda horse2)
        {
            int massOfTelega = horse1.Mass + horse2.Mass;
            int powerOfTelega = horse1.Power + horse2.Power;
            var Horse = new Poroda("Лошадь", massOfTelega, powerOfTelega);
            return Horse;
        }
    }
}
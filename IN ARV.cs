using System;

namespace IN_1
{
    internal interface IN_ARV
    {
    }

    public class Drink
    {
        // Attributer

        public string Name;

        public string Test;

        // Metoder

        public void sup()
        {
            Console.WriteLine(" this drink is Water");

        }
        public void sul()
        {
            Console.WriteLine("Water test nothing");
        }
    }


    public class Juice : Drink
    {
        // Attributer

        public string fruit;

        public string extracted;

        // Metoder

        public void dup()
        {
            Console.WriteLine(" this drink is Juice");

        }
        public void dul()
        {
            Console.WriteLine("Juice test sweet");
        }


    }

}

using System.Data.Common;

namespace OhSyTe
{
    public class Program
    {
        public static void Main()
        {
            Country[] countries = {
                new Country("FI", "Finland", 338_435, 5_553_000, new City("Helsinki", new Coordinates(8.3456, 23.7654))),
                new Country("GB", "Great-Britain", 556_985, 34_456_000, new City("London", new Coordinates(-7.345, 2.754))),
                new Country("IT", "Italy", 496_234, 20_456_000, new City("Rome", new Coordinates(56.234, 2.456))),
                new Country("FR", "France", 2_456_095, 42_567_000, new City("Paris", new Coordinates(47.2345, -22.3445))),
                new Country("SE", "Sweden", 440_836, 7_083_000, new City("Stockholm", new Coordinates(-2.3356, -34.567)))
            };

            foreach (Country country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine("\nArray length: " + countries.Length);

            /*
            Country[] countries = new Country[5];
            countries[0] = finland;
            countries[1] = gb;
            countries[2] = italy;
            countries[3] = france;
            countries[4] = sweden;

            foreach (Country country in countries)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine("\nArray length: " + countries.Length);
            */
        }
    }
}
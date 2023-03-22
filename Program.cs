using System.Data.Common;

namespace OhSyTe
{
    public class Program
    {
        public static void Main()
        {
            
            Country finland = new Country("FI", "Finland", 338_435, 5_553_000);
            Country gb = new Country("GB", "Great-Britain", 556_985, 34_456_000);
            Country italy = new Country("IT", "Italy", 496_234, 20_456_000);
            Country france = new Country("FR", "France", 2_456_095, 42_567_000);
            Country sweden = new Country("SE", "Sweden", 440_836, 7_083_000);

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
        }
    }
}
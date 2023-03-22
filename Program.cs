namespace OhSyTe
{
    public class Program
    {
        public static void Main()
        {   try
            {
                Country fin = new Country("FI", "Finland", 44, 4);
                Console.WriteLine(fin);
            } catch (Exception e) { Console.Error.WriteLine(e.Message); }
        }
    }
}
using System.ComponentModel.Design;

namespace Ratespiel_umgedreht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tipp = rnd.Next(1, 101);
            Console.WriteLine($"Ist es {tipp}?");
            string antwort = Console.ReadLine();
           
            if (antwort.ToLower().Contains("tiefer"))
            {
                Console.WriteLine("Okay, tiefer.");
            }
            else if (antwort.ToLower().Contains("höher"))
            {
                Console.WriteLine("Okay, höher.");
            }
            else if (antwort.ToLower().Contains("richtig"))
            {
                Console.WriteLine("Ich hab's!");
            }
            else
                Console.WriteLine("Das hab ich nicht verstanden!");
        }  

    }
}
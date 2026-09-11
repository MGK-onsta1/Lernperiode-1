using System.ComponentModel.Design;

namespace Ratespiel_umgedreht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int min = 1;
            int max = 100;
            string antwort;  
            int versuche = 0;

            do
            {
                int tipp = rnd.Next(min, max + 1);
                versuche++;
                Console.WriteLine($"Ist es {tipp}?");
                antwort = Console.ReadLine().ToLower();

                if (antwort.Contains("tiefer"))
                {
                    Console.WriteLine("Okay, tiefer.");
                    max = tipp - 1;
                }
                else if (antwort.Contains("höher"))
                {
                    Console.WriteLine("Okay, höher.");
                    min = tipp + 1;
                }
                else if (antwort.Contains("richtig"))
                {
                    Console.WriteLine("Ich hab's!");
                }
                else
                {
                    Console.WriteLine("Das hab ich nicht verstanden!");
                }

            } while (!antwort.Contains("richtig"));

            Console.WriteLine($"Ich habe {versuche} Versuche gebraucht!");
        }
    }
}
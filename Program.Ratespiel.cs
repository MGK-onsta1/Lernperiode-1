namespace Ratespiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int geheimeZahl = rnd.Next(1, 101);
            int tipp;
            int versuche = 0;

            Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100 gewählt");
            do
            {
                Console.WriteLine("Dein Tipp: ");
                tipp = Convert.ToInt32(Console.ReadLine());
                versuche++;

                if (tipp < geheimeZahl)
                    Console.WriteLine("zu klein");
                else if (tipp > geheimeZahl)
                    Console.WriteLine("zu gross");
                else
                    Console.WriteLine($"Richtig! Du hast {versuche} Versuche gebraucht");
            } while (tipp != geheimeZahl);
                                 
        }
    }
}

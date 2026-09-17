using System;

class Program
{
    static void Main()
    {
        string antwort = "j";

        
        while (antwort == "j")
        {
            Console.Clear();
            Console.WriteLine("--- Einfacher Taschenrechner ---");

            
            Console.Write("Erste Zahl: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

           
            Console.Write("Operator (+, -, *, /): ");
            string op = Console.ReadLine();

            
            Console.Write("Zweite Zahl: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            double ergebnis = 0;

            
            if (op == "+")
            {
                ergebnis = zahl1 + zahl2;
            }
            else if (op == "-")
            {
                ergebnis = zahl1 - zahl2;
            }
            else if (op == "*")
            {
                ergebnis = zahl1 * zahl2;
            }
            else if (op == "/")
            {
                ergebnis = zahl1 / zahl2;
            }

          
            Console.WriteLine("Ergebnis: " + ergebnis);

            
            Console.Write("\nNochmal rechnen? (j/n): ");
            antwort = Console.ReadLine();
        }

        Console.WriteLine("Tschüss!");
    }
}
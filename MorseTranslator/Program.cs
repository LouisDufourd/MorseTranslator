using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            GestionMorse gestion = new GestionMorse();
            do
            {
                Console.WriteLine("Entrez un message à traduire en morse (§end pour stoper le programme)");
                message = Console.ReadLine();
                if (message != "§end")
                {
                    gestion.Transalte(message);
                }
            } while (message != "§end");
        }
    }
}

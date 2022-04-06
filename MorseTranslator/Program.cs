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
            string message = Console.ReadLine();
            //GestionMorse gestion = new GestionMorse();
            GestionMorse gestion = new GestionMorse();
            gestion.Transalte(message);
            Console.ReadLine();
        }
    }
}

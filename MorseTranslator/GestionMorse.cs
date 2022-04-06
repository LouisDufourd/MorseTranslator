using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator
{
    class GestionMorse
    {
        public ArrayList code = new ArrayList(50);

        public GestionMorse()
        {
            int[] lettres = new int[2];
            lettres[0] = 100;
            lettres[1] = 500;
            code.Add(new Morse('a', lettres, 770));
        }

        public void Transalte(string chaine)
        {
            Array array = chaine.ToCharArray();
            foreach (char c in array)
            {
                Console.WriteLine(c);
                foreach (Morse morse in code)
                {
                    if(morse.GetLettre() == c)
                    {
                        foreach (int duree in morse.getDuree())
                        {
                            Console.Beep(morse.GetFrequence(), duree);
                        }
                    }
                }
            }
        }
    }
}

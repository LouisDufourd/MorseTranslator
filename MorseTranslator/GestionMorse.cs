using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator
{
    class GestionMorse
    {
        public Morse [] code = new Morse[26];

        public GestionMorse()
        {
            //a
            int[] lettres = new int[2];
            lettres[0] = 100;
            lettres[1] = 300;
            code[0] = new Morse('a', lettres, 770);
            //b
            lettres = new int[4];
            lettres[0] = 300;
            lettres[1] = 100;
            lettres[2] = 100;
            lettres[3] = 100;
            code[1] = new Morse('b', lettres, 770);
            //c
            lettres = new int[4];
            lettres[0] = 300;
            lettres[1] = 100;
            lettres[2] = 300;
            lettres[3] = 100;
            code[2] = new Morse('c', lettres, 770);
            //d
            lettres = new int[3];
            lettres[0] = 300;
            lettres[1] = 100;
            lettres[2] = 100;
            code[3] = new Morse('d', lettres, 770);
            //e
            lettres = new int[1];
            lettres[0] = 100;
            code[4] = new Morse('e', lettres, 770);
            //f
            lettres = new int[4];
            lettres[0] = 100;
            lettres[1] = 100;
            lettres[2] = 300;
            lettres[3] = 100;
            code[5] = new Morse('f', lettres, 770);
            //g
            lettres = new int[3];
            lettres[0] = 300;
            lettres[1] = 300;
            lettres[2] = 100;
            code[6] = new Morse('g', lettres, 770);
            //h
            lettres = new int[4];
            lettres[0] = 100;
            lettres[1] = 100;
            lettres[2] = 100;
            lettres[3] = 100;
            code[7] = new Morse('h', lettres, 770);
            //i
            lettres = new int[2];
            lettres[0] = 100;
            lettres[1] = 100;
            code[8] = new Morse('i', lettres, 770);
            //j
            lettres = new int[4];
            lettres[0] = 100;
            lettres[1] = 300;
            lettres[2] = 300;
            lettres[3] = 300;
            code[9] = new Morse('j', lettres, 770);
            //k
            lettres = new int[3];
            lettres[0] = 300;
            lettres[1] = 100;
            lettres[2] = 300;
            code[10] = new Morse('k', lettres, 770);
            //l
            lettres = new int[4];
            lettres[0] = 100;
            lettres[1] = 300;
            lettres[2] = 100;
            lettres[3] = 100;
            code[11] = new Morse('l', lettres, 770);
            //m
            lettres = new int[2];
            lettres[0] = 300;
            lettres[1] = 300;
            code[12] = new Morse('m', lettres, 770);
            //n
            lettres = new int[2];
            lettres[0] = 300;
            lettres[1] = 100;
            code[13] = new Morse('n', lettres, 770);
            //o
            lettres = new int[3];
            lettres[0] = 300;
            lettres[1] = 300;
            lettres[2] = 300;
            code[14] = new Morse('o', lettres, 770);
            //p
            lettres = new int[4];
            lettres[0] = 100;
            lettres[1] = 300;
            lettres[2] = 300;
            lettres[3] = 100;
            code[15] = new Morse('p', lettres, 770);
            //q
            lettres = new int[4];
            lettres[0] = 100;
            lettres[1] = 300;
            lettres[2] = 300;
            lettres[3] = 100;
            code[16] = new Morse('q', lettres, 770);
            //r
            lettres = new int[3];
            lettres[0] = 100;
            lettres[1] = 300;
            lettres[2] = 100;
            code[17] = new Morse('r', lettres, 770);
            //s
            lettres = new int[3];
            lettres[0] = 100;
            lettres[1] = 100;
            lettres[2] = 100;
            code[18] = new Morse('s', lettres, 770);
            //t
            lettres = new int[1];
            lettres[0] = 300;
            code[19] = new Morse('t', lettres, 770);
            //u
            lettres = new int[3];
            lettres[0] = 100;
            lettres[1] = 100;
            lettres[2] = 300;
            code[20] = new Morse('u', lettres, 770);
            //v
            lettres = new int[4];
            lettres[0] = 100;
            lettres[1] = 100;
            lettres[2] = 100;
            lettres[3] = 300;
            code[21] = new Morse('v', lettres, 770);
            //w
            lettres = new int[3];
            lettres[0] = 100;
            lettres[1] = 300;
            lettres[2] = 300;
            code[22] = new Morse('w', lettres, 770);
            //x
            lettres = new int[4];
            lettres[0] = 300;
            lettres[1] = 100;
            lettres[2] = 100;
            lettres[3] = 300;
            code[23] = new Morse('x', lettres, 770);
            //y
            lettres = new int[4];
            lettres[0] = 300;
            lettres[1] = 100;
            lettres[2] = 300;
            lettres[3] = 300;
            code[24] = new Morse('y', lettres, 770);
            //z
            lettres = new int[4];
            lettres[0] = 300;
            lettres[1] = 300;
            lettres[2] = 100;
            lettres[3] = 100;
            code[25] = new Morse('z', lettres, 770);
            //space
            lettres = new int[1];
            lettres[0] = 700;
            code[21] = new Morse(' ', lettres, 770);
        }

        public void Transalte(string chaine)
        {
            char[] messages = chaine.ToCharArray();
            for (int i = 0; i < messages.Length; i++)
            {
                for (int j = 0; j < code.Length; j++)
                {
                    if (code[j].GetLettre() == char.ToLower(messages[i]))
                    {
                        int[] dure = code[j].getDuree();
                        for (int k = 0; k < dure.Length; k++)
                        {
                            Console.WriteLine(dure[k]);
                            //Console.Beep(code[j].GetFrequence(), dure[k]);
                        }
                        if(code[j + 1].GetLettre() != ' ' && code[j+1] != code[j])
                        {
                            Console.WriteLine("300");
                        }
                    }
                }
            }
        }
    }
}

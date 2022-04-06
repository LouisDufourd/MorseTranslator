using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseTranslator
{
    class Morse
    {
        private char lettre;
        private int[] duree;
        private int frequence;

        public Morse(char lettre, int[] duree, int frequence)
        {
            this.duree = duree;
            this.lettre = lettre;
            this.frequence = frequence;
        }

        public char GetLettre()
        {
            return this.lettre;
        }

        public int[] getDuree()
        {
            return this.duree;
        }

        public int GetFrequence()
        {
            return this.frequence;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Beagle : Dog
    {
        public int Anni { get; set; }
        public Beagle(int anni)
        {
            Anni = anni;
        }
        public void Speak()
        {
            Console.WriteLine("Ciao sono un beagle");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Boxer : Dog
    {
        public int Denti { get; set; }
        public void Speak()
        {
            Console.WriteLine("Ciao sono un boxer");
        }
    }
}

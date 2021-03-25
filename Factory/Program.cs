using Factory.Es_Imprese;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ////so che devo creare un cane ma non so come viene chiamato
            //Console.WriteLine("Inserisci la razza del cane tra:\nBoxer\nBeagle\nYorkshire");
            //string razza = Console.ReadLine();
            //Factory.FactoryDog(razza);

            //Esercizio imprese
            Console.WriteLine("Inserisci il numero dei dipendenti:");
            bool corretto = false;
            int nDip = 0;
            do
            {
                corretto = Int32.TryParse(Console.ReadLine(), out nDip);
            } while (corretto != true);

            FactoryImprese.Factory(nDip);
            
        }
    }
}

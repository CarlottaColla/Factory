using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Es_Imprese
{
    class MultinazionaleImpresa : IImpresa
    {
        public int NumDipendenti { get; set; }
        public void CreaImpresa()
        {
            Console.WriteLine("Multinazionale creata!");
        }
    }
}

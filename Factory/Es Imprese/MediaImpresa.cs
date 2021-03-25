using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Es_Imprese
{
    class MediaImpresa : IImpresa
    {
        public int NumDipendenti { get; set; }
        public void CreaImpresa()
        {
            Console.WriteLine("Media impresa creata!");
        }
    }
}

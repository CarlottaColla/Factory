using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Es_Imprese
{
    class FactoryImprese
    {
        public static void Factory(int nDipendenti)
        {
            IImpresa impresa;

            //IF
            if(nDipendenti < 0)
            {
                Console.WriteLine("Erroe");
                return;
            } 
            if(nDipendenti <= 20)
            {
                impresa = new PiccolaImpresa();
                impresa.NumDipendenti = nDipendenti;
            }
            else if(nDipendenti <= 100)
            {
                impresa = new MediaImpresa();
                impresa.NumDipendenti = nDipendenti;
            }
            else if(nDipendenti <= 500)
            {
                impresa = new GrandeImpresa();
                impresa.NumDipendenti = nDipendenti;
            }
            else
            {
                impresa = new MultinazionaleImpresa();
                impresa.NumDipendenti = nDipendenti;
            }

            impresa.CreaImpresa();
        }
    }
}

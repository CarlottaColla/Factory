using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Es_Imprese
{
    interface IImpresa
    {
        int NumDipendenti { get; set; }
        void CreaImpresa();
    }
}

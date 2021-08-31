using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Repository.Contracts
{
    public interface ICaoRepository
    {
        Cao GetCaoByNome(string nomeCao);        
        Cao GetCaoByCPFDono(int donoID);
    }
}

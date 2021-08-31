using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Repository.Contracts
{
    public interface ICaoRepository
    {           
        Cao GetCaoByID(int idCao);
        Cao GetCaoByNome(string nomeCao);
    }
}

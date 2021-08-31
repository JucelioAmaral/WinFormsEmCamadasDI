using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Repository.Contracts
{
    public interface ICaoRepository
    {
        Task<Cao> GetCaoByID(int idCao);
        Task<Cao> GetCaoByNome(string nomeCao, int IDDono);
    }
}

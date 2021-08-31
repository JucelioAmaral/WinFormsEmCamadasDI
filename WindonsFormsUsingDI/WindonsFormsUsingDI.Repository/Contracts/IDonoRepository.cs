using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Repository.Contracts
{
    public interface IDonoRepository
    {
        Task<Dono> GetDonoByCPF(string donoId);
    }
}

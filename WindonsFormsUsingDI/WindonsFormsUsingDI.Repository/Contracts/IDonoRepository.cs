using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Repository.Contracts
{
    public interface IDonoRepository
    {
        Dono GetDonoByCPF(string donoId);

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Application.Contracts
{
    public interface IDonoService
    {
        Task<bool> AddDono(DonoDto dono);
        Task<bool> UpdateDono(string cpfSelecionado, DonoDto dono);
        Task<bool> DeleteDono(string cpfSelecionado);

        //DonoDto GetDono(string cpf);
        Task<Dono> GetDono(string cpf);
    }
}

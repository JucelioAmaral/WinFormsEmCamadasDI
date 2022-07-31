using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Application.Dtos;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Application.Contracts
{
    public interface ICaoService
    {
        Task<bool> AddCao(int IdDono, CaoDto dono);
        Task<bool> UpdateCao(int IdcaoSelecionado, CaoDto dono);
        Task<bool> DeleteCao(int IdcaoSelecionado);

        //CaoDto GetCaoByNomeCao(string nomeCao);             
        Task<Cao> GetCaoByNomeCao(string nomeCao, int IDDono);
        Task<Cao> GetCaoByIdDonoBD(int IDDono);
    }
}

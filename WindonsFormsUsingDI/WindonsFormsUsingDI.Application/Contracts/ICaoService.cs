using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Application.Dtos;

namespace WindonsFormsUsingDI.Application.Contracts
{
    public interface ICaoService
    {
        bool AddCao(int IdDono, CaoDto dono);
        bool UpdateCao(string caoSelecionado, CaoDto dono);
        bool DeleteCao(string caoSelecionado);

        CaoDto GetCaoByNomeCao(string nomeCao);             
    }
}

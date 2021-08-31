using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Application.Dtos;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Application.Contracts
{
    public interface ICaoService
    {
        bool AddCao(int IdDono, CaoDto dono);
        bool UpdateCao(int IdcaoSelecionado, CaoDto dono);
        bool DeleteCao(int IdcaoSelecionado);

        //CaoDto GetCaoByNomeCao(string nomeCao);             
        Cao GetCaoByNomeCao(string nomeCao);
    }
}

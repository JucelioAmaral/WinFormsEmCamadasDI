﻿using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Application.Contracts
{
    public interface IDonoService
    {
        bool AddDono(DonoDto dono);
        bool UpdateDono(string cpfSelecionado, DonoDto dono);
        bool DeleteDono(string cpfSelecionado);

        //DonoDto GetDono(string cpf);
        Dono GetDono(string cpf);
    }
}

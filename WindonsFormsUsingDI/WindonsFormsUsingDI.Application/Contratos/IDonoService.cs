using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Application.Contratos
{
    public interface IDonoService
    {
        bool AddDono(Dono dono);
        bool UpdateDono(int donoId, Dono dono);
        bool DeleteDono(Dono dono);
        DonoDto GetDono(string cpf);

        void ListarRelacionamentoDonoCao();
        void GerarRelatório();
    }
}

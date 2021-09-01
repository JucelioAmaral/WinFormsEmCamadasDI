using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Application.Dtos;

namespace WindonsFormsUsingDI.Application.Contracts
{
    public interface IGeralService
    {
        Task<bool> GeraRelatório(string raca, string diretorio);
        Task<DonoCaoDto[]> ListarRelacionamentoDonoCao();
        Task<DonoCaoDto[]> ListarRelacionamentoDonoCaoPorRaca(string raca);
    }
}

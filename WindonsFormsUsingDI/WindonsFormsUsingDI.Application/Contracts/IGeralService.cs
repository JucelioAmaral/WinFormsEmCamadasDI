using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Application.Dtos;

namespace WindonsFormsUsingDI.Application.Contracts
{
    public interface IGeralService
    {
        Task<DonoCaoDto> GetAll();
        Task<DonoCaoDto> GeraRelatório();
        Task<DonoCaoDto> ListarRelacionamentoDonoCao();        
    }
}

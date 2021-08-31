using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Application.Dtos;

namespace WindonsFormsUsingDI.Application.Contracts
{
    public interface IGeralService
    {
        DonoCaoDto GetAll();
        DonoCaoDto GeraRelatório();
        DonoCaoDto ListarRelacionamentoDonoCao();        
    }
}

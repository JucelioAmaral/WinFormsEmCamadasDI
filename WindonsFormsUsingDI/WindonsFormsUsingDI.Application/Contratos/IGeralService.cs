using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Application.Dtos;

namespace WindonsFormsUsingDI.Application.Contratos
{
    public interface IGeralService
    {
        DonoCaoDto GetAll();
        DonoCaoDto GeraRelatório();
    }
}

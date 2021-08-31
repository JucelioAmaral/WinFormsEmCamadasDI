using System.Threading.Tasks;
using WindonsFormsUsingDI.Application.Contracts;
using WindonsFormsUsingDI.Application.Dtos;

namespace WindonsFormsUsingDI.Application
{
    public class GeralService : IGeralService
    {

        /// <summary>
        /// Busca os registros para preencher o DataGridView
        /// </summary>
        /// <returns></returns>
        public async Task<DonoCaoDto> GetAll()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// Gera relatório
        /// </summary>
        /// <returns>Gera relatório em excel.</returns>
        public async Task<DonoCaoDto> GeraRelatório()
        {
            throw new System.NotImplementedException();
        }

        public async Task<DonoCaoDto> ListarRelacionamentoDonoCao()
        {
            throw new System.NotImplementedException();
        }
    }
}

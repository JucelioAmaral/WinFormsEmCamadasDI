using WindonsFormsUsingDI.Application.Contratos;
using WindonsFormsUsingDI.Application.Dtos;

namespace WindonsFormsUsingDI.Application
{
    public class GeralService : IGeralService
    {
        /// <summary>
        /// Busca os registros para preencher o DataGridView
        /// </summary>
        /// <returns></returns>
        public DonoCaoDto GetAll()
        {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// Gera relatório
        /// </summary>
        /// <returns>Gera relatório em excel.</returns>
        public DonoCaoDto GeraRelatório()
        {
            throw new System.NotImplementedException();
        }
    }
}

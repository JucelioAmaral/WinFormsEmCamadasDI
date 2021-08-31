using System.Threading.Tasks;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Repository.Contracts
{
    public interface IGeralRelatorioRepository
    {        
        Task<Dono[]> GetAllDono();
        Task<Cao[]> GetAllCao();
    }
}

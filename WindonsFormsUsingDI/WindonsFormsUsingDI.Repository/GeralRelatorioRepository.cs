using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Domain;
using WindonsFormsUsingDI.Repository.Contracts;

namespace WindonsFormsUsingDI.Repository
{
    public class GeralRelatorioRepository : IGeralRelatorioRepository
    {
        private readonly DatabaseContext _context;

        public GeralRelatorioRepository(DatabaseContext context)
        {
            _context = context;
        }

        async Task<Cao[]> IGeralRelatorioRepository.GetAllCao()
        {
            IQueryable<Cao> queryCao = _context.tblCao;
            queryCao = queryCao.AsNoTracking().OrderBy(c => c.CaoId);// Ordenado por Id.
            return await queryCao.ToArrayAsync();
        }

        async Task<Dono[]> IGeralRelatorioRepository.GetAllDono()
        {
            IQueryable<Dono> queryDono = _context.tblDono;
            queryDono = queryDono.AsNoTracking().OrderBy(d => d.DonoId);// Ordenado por Id.
            return await queryDono.ToArrayAsync();
        }
    }
}

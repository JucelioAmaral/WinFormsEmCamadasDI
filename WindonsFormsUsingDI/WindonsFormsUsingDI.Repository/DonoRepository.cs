using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Domain;
using WindonsFormsUsingDI.Repository.Contracts;

namespace WindonsFormsUsingDI.Repository
{
    public class DonoRepository : IDonoRepository
    {
        private readonly DatabaseContext _context;

        public DonoRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Dono> GetDonoByCPF(string cpf)
        {
            IQueryable<Dono> query = _context.tblDono;
            query = query.AsNoTracking()
                .OrderBy(d => d.DonoId)
                .Where(d => d.CPF == cpf);
            return await query.FirstOrDefaultAsync();
        }
    }
}

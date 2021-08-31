using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Domain;
using WindonsFormsUsingDI.Repository.Contracts;

namespace WindonsFormsUsingDI.Repository
{

    public class CaoRepository : ICaoRepository
    {
        private readonly DatabaseContext _context;

        public CaoRepository(DatabaseContext context)
        {
            _context = context;

        }

        public async Task<Cao> GetCaoByID(int idCao)
        {
            IQueryable<Cao> query = _context.tblCao;
            query = query.AsNoTracking()
                .OrderBy(c => c.CaoId)
                .Where(d => d.CaoId == idCao);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Cao> GetCaoByNome(string nomeCao, int IDDono)
        {
            IQueryable<Cao> query = _context.tblCao;

            query = query.AsNoTracking()
             .Where(cao => cao.NomeCao == nomeCao
             && cao.DonoId == IDDono);

            return  await query.FirstOrDefaultAsync();
        }
    }
}

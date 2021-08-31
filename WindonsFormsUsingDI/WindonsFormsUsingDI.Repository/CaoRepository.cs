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

        public Task<Cao[]> GetCaoByCPFDono(int donoID)
        {
            IQueryable<Cao> query = _context.tblCao;

            query = query.AsNoTracking()
                         .Where(cao => cao.DonoId == donoID);

            return query.ToArrayAsync();
        }

        public Cao GetCaoByNome(string nomeCao)
        {
            IQueryable<Cao> query = _context.tblCao;
            query = query.Where(d => d.NomeCao == nomeCao);
            return  query.FirstOrDefault();

            //int idCao
            //IQueryable<Dono> query = _context.tblDono
            //.Include(c => c.Caes);

            //query = query.AsNoTracking().OrderBy(c => c.DonoId)
            //                .Where(c => c.DonoId == idCao);
                        
            //return query.FirstOrDefault();
        }

        Cao ICaoRepository.GetCaoByCPFDono(int donoID)
        {
            throw new NotImplementedException();
        }
    }
}

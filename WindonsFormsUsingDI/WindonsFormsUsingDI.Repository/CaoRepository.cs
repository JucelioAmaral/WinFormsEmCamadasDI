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

        public Cao GetCaoByID(int idCao)
        {
            IQueryable<Cao> query = _context.tblCao;
            query = query.Where(d => d.CaoId == idCao);
            return query.FirstOrDefault();
        }

        public Cao GetCaoByNome(string nomeCao)
        {
            IQueryable<Cao> query = _context.tblCao;
            query = query.Where(d => d.NomeCao == nomeCao);
            return  query.FirstOrDefault();
        }
    }
}

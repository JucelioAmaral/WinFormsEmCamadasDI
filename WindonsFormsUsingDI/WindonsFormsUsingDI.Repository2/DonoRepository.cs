using System.Linq;
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

        public Dono GetDonoByCPF(string cpf)
        {
            IQueryable<Dono> query = _context.tblDono.Where(d => d.CPF == cpf);
            query = query.Where(d => d.CPF == cpf);
            return query.FirstOrDefault();
        }
    }
}

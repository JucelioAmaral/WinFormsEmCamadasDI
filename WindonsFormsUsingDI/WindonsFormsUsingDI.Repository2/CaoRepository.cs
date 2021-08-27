using System;
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
    }
}

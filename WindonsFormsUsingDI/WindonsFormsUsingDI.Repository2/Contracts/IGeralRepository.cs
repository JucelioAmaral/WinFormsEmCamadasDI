using System;
using System.Collections.Generic;
using System.Text;

namespace WindonsFormsUsingDI.Repository.Contracts
{
    public interface IGeralRepository
    {
        // GERAL, para todos os eventos abaixo de qq classe.
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void GetAll<T>(T entity) where T : class;
        bool SaveChanges();
    }
}

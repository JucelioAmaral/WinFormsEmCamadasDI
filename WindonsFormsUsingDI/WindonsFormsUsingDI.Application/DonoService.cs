using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WindonsFormsUsingDI.Application.Contratos;
using WindonsFormsUsingDI.Domain;
using WindonsFormsUsingDI.Repository.Contracts;

namespace WindonsFormsUsingDI.Application
{
    public class DonoService : IDonoService
    {
        private readonly IGeralRepository _geralRepository;
        private readonly IDonoRepository _donoRepository;
        private readonly IMapper _mapper;

        public DonoService(IGeralRepository geralRepository, IDonoRepository donoRepository, IMapper mapper)
        {
            _donoRepository = donoRepository;
            _geralRepository = geralRepository;
            _mapper = mapper;
        }

        public DonoDto GetDono(string cpf)
        {
            var donoSelecionado = _donoRepository.GetDonoByCPF(cpf);
            if (donoSelecionado == null) return null;
            return _mapper.Map<DonoDto>(donoSelecionado);
        }

        public bool AddDono(Dono dono)
        {
            _geralRepository.Add<Dono>(dono);
            if (_geralRepository.SaveChanges())
            {
                return true;
            }
            return false;
        }
        public bool UpdateDono(int id, Dono dono)
        {
            _geralRepository.Update<Dono>(dono);
            if (_geralRepository.SaveChanges())
            {
                return true;
            }
            return false;
        }
        public bool DeleteDono(Dono dono)
        {
            throw new NotImplementedException();
        }

        public void GerarRelatório()
        {
            throw new NotImplementedException();
        }

        public void ListarRelacionamentoDonoCao()
        {
            throw new NotImplementedException();
        }
    }
}

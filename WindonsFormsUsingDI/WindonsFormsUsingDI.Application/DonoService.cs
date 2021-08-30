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

        public bool AddDono(DonoDto donodto)
        {
            var dono = _mapper.Map<Dono>(donodto);
            _geralRepository.Add<Dono>(dono);
            if (_geralRepository.SaveChanges())
            {
                return true;
            }
            return false;
        }
        public bool UpdateDono(string cpf, DonoDto dono)
        {
            var donoSelecionado = _donoRepository.GetDonoByCPF(cpf);
            if (donoSelecionado == null) return false;

            dono.Id = donoSelecionado.DonoId;
            _mapper.Map(dono, donoSelecionado);
            _geralRepository.Update<Dono>(donoSelecionado);
            if (_geralRepository.SaveChanges())
            {
                return true;
            }
            return false;
        }
        public bool DeleteDono(DonoDto dono)
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

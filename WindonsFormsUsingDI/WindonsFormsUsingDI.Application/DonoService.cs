using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Application.Contracts;
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

        public async Task<bool> AddDono(DonoDto donodto)
        {
            var dono = _mapper.Map<Dono>(donodto);
            _geralRepository.Add<Dono>(dono);
            if (await _geralRepository.SaveChangesAsync())
            {
                return true;
            }
            return false;
        }
        public async Task<bool> UpdateDono(string cpf, DonoDto dono)
        {
            var donoSelecionado = await _donoRepository.GetDonoByCPF(cpf);
            if (donoSelecionado == null) return false;

            dono.Id = donoSelecionado.DonoId;
            _mapper.Map(dono, donoSelecionado);
            _geralRepository.Update<Dono>(donoSelecionado);
            if (await _geralRepository.SaveChangesAsync())
            {
                return true;
            }
            return false;
        }
        public async Task<bool> DeleteDono(string cpf)
        {
            var donoSelecionado = await _donoRepository.GetDonoByCPF(cpf);
            if (donoSelecionado == null) return false;
            _geralRepository.Delete(donoSelecionado);

            if (await _geralRepository.SaveChangesAsync())
            {
                return true;
            }
            return false;
        }

        public async Task<Dono> GetDono(string cpf)
        {
            var donoSelecionado = await _donoRepository.GetDonoByCPF(cpf);
            if (donoSelecionado == null) return null;
            return donoSelecionado;
        }
    }
}

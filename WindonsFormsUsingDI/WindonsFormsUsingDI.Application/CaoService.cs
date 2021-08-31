using AutoMapper;
using WindonsFormsUsingDI.Application.Contracts;
using WindonsFormsUsingDI.Application.Dtos;
using WindonsFormsUsingDI.Domain;
using WindonsFormsUsingDI.Repository.Contracts;

namespace WindonsFormsUsingDI.Application
{
    public class CaoService : ICaoService
    {
        private readonly IGeralRepository _geralRepository;
        private readonly ICaoRepository _caoRepository;
        private readonly IMapper _mapper;


        public CaoService(IGeralRepository geralRepository, ICaoRepository caoRepository, IMapper mapper)
        {
            _geralRepository = geralRepository;
            _caoRepository = caoRepository;
            _mapper = mapper;
        }
        public CaoDto GetCaoByNomeCao(string nomeCao)
        {
            var donoSelecionado = _caoRepository.GetCaoByNome(nomeCao);
            if (donoSelecionado == null) return null;
            return _mapper.Map<CaoDto>(donoSelecionado);            
        }
                
        public CaoDto GetCao(string cpfDono)
        {

            return null;
        }
        public bool AddCao(int IDDono, CaoDto caoDto)
        {
            var cao = _mapper.Map<Cao>(caoDto);
            cao.DonoId = IDDono;
            _geralRepository.Add<Cao>(cao);
            if (_geralRepository.SaveChanges())
            {
                return true;
            }
            return false;
        }

        public bool DeleteCao(string caoSelecionado)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateCao(string caoSelecionado, CaoDto dono)
        {
            throw new System.NotImplementedException();
        }

    }
}

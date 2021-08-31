using AutoMapper;
using System.Threading.Tasks;
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
        //public CaoDto GetCaoByNomeCao(string nomeCao)
        public async Task<Cao> GetCaoByNomeCao(string nomeCao, int IDDono)
        {
            var donoSelecionado = await _caoRepository.GetCaoByNome(nomeCao, IDDono);
            if (donoSelecionado == null) return null;
            //return _mapper.Map<CaoDto>(donoSelecionado);            
            return donoSelecionado;
        }
                
        public CaoDto GetCao(string cpfDono)
        {

            return null;
        }
        public async Task<bool> AddCao(int IDDono, CaoDto caoDto)
        {
            var cao = _mapper.Map<Cao>(caoDto);
            cao.DonoId = IDDono;
            _geralRepository.Add<Cao>(cao);
            if (await _geralRepository.SaveChangesAsync())
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteCao(int IDcaoSelecionado)
        {
            var caoSelecionado = await _caoRepository.GetCaoByID(IDcaoSelecionado);
            if (caoSelecionado == null) return false;
            _geralRepository.Delete(caoSelecionado);

            if (await _geralRepository.SaveChangesAsync())
            {
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateCao(int IDcaoSelecionado, CaoDto cao)
        {
            var caoSelecionado = await _caoRepository.GetCaoByID(IDcaoSelecionado);
            if (caoSelecionado == null) return false;

            cao.Id = caoSelecionado.CaoId;
            _mapper.Map(cao, caoSelecionado);
            _geralRepository.Update<Cao>(caoSelecionado);
            if (await _geralRepository.SaveChangesAsync())
            {
                return true;
            }
            return false;
        }

    }
}

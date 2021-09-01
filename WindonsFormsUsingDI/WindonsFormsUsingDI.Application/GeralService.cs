using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindonsFormsUsingDI.Application.Contracts;
using WindonsFormsUsingDI.Application.Dtos;
using WindonsFormsUsingDI.Repository.Contracts;

namespace WindonsFormsUsingDI.Application
{
    public class GeralService : IGeralService
    {

        private readonly IGeralRelatorioRepository _geralRelatorioRepository;
        private readonly IMapper _mapper;

        public GeralService(IGeralRelatorioRepository geralRelatorioRepository, IMapper mapper)
        {
            _geralRelatorioRepository = geralRelatorioRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Gera relatório
        /// </summary>
        /// <returns>Gera relatório em excel.</returns>
        public Task<DonoCaoDto[]> GeraRelatório()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Busca os registros para preencher o DataGridView
        /// </summary>
        /// <returns></returns>
        public async Task<DonoCaoDto[]> ListarRelacionamentoDonoCao()
        {
            DonoCaoDto donoEcao = null;
            List<DonoCaoDto> relatorioDonoCao = null;

            var donos = await _geralRelatorioRepository.GetAllDono();
            var caes = await _geralRelatorioRepository.GetAllCao();

            relatorioDonoCao = new List<DonoCaoDto>();

            // Join cao and dono based on DonoId
            var query = from dono in donos
                        join cao in caes on dono.DonoId equals cao.DonoId
                        select new { dono.NomeDono, dono.CPF, dono.Telefone, cao.NomeCao, cao.Raca };


            foreach (var i in query)
            {
                donoEcao = new DonoCaoDto()
                {
                    NomeDono = i.NomeDono,
                    CPF = i.CPF,
                    Telefone = i.Telefone,
                    NomeCao = i.NomeCao,
                    RacaCao = i.Raca
                };
              relatorioDonoCao.Add(donoEcao);
            }

            var results = _mapper.Map<DonoCaoDto[]>(relatorioDonoCao);

            return results;

        }
    }
}

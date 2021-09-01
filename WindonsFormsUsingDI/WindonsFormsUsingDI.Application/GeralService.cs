using AutoMapper;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
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
        public async Task<bool> GeraRelatório(string raca, string diretorio)
        {         
            try
            {            
                var DonosESeusCaes = await ListarRelacionamentoDonoCaoPorRaca(raca);                
                if (DonosESeusCaes == null)
                {
                    return false;
                }
                else
                {
                    using (var workbook = new XLWorkbook())
                    {
                        //Formatação dos nomes das colunas 
                        var worksheet = workbook.Worksheets.Add("RelacionamentoDono&Cao");
                        var currentRow = 1;
                        worksheet.Cell(currentRow, 1).Value = "Nome do Dono";
                        worksheet.Cell(currentRow, 2).Value = "CPF";
                        worksheet.Cell(currentRow, 3).Value = "Telefone";
                        worksheet.Cell(currentRow, 4).Value = "Nome do Cão";
                        worksheet.Cell(currentRow, 5).Value = "Raça do Cão";

                        //Cor de fundo da celula
                        worksheet.Cell(currentRow, 1).Style.Fill.BackgroundColor = XLColor.LightGreen;
                        worksheet.Cell(currentRow, 2).Style.Fill.BackgroundColor = XLColor.LightGreen;
                        worksheet.Cell(currentRow, 3).Style.Fill.BackgroundColor = XLColor.LightGreen;
                        worksheet.Cell(currentRow, 4).Style.Fill.BackgroundColor = XLColor.LightGreen;
                        worksheet.Cell(currentRow, 5).Style.Fill.BackgroundColor = XLColor.LightGreen;

                        //Estilo das bordas das celulas
                        worksheet.Cell(currentRow, 1).Style.Border.OutsideBorder = XLBorderStyleValues.Double;
                        worksheet.Cell(currentRow, 2).Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                        worksheet.Cell(currentRow, 3).Style.Border.OutsideBorder = XLBorderStyleValues.Hair;
                        worksheet.Cell(currentRow, 4).Style.Border.OutsideBorder = XLBorderStyleValues.Dotted;
                        worksheet.Cell(currentRow, 5).Style.Border.OutsideBorder = XLBorderStyleValues.Medium;

                        //Cor da fonte das palavras
                        worksheet.Cell(currentRow, 1).Style.Font.FontColor = XLColor.Red;
                        worksheet.Cell(currentRow, 2).Style.Font.FontColor = XLColor.Blue;
                        worksheet.Cell(currentRow, 3).Style.Font.FontColor = XLColor.Violet;
                        worksheet.Cell(currentRow, 4).Style.Font.FontColor = XLColor.BlueGray;
                        worksheet.Cell(currentRow, 5).Style.Font.FontColor = XLColor.DarkGreen;

                        //Preenchimento da planilha
                        foreach (var m in DonosESeusCaes)
                        {
                            currentRow++;
                            worksheet.Cell(currentRow, 1).Value = m.NomeDono;
                            worksheet.Cell(currentRow, 2).Value = m.CPF;
                            worksheet.Cell(currentRow, 3).Value = m.Telefone;
                            worksheet.Cell(currentRow, 4).Value = m.NomeCao;
                            worksheet.Cell(currentRow, 5).Value = m.RacaCao;
                        }

                        //Salva a planilha
                        using (var stream = new MemoryStream())
                        {
                            workbook.SaveAs(stream);
                            var content = stream.ToArray();
                            //workbook.SaveAs(@"E:\APLICAÇÕES E CURSOS\PROVA EDESOFT\ProvaEdesoft\RelatorioDonoCao.xlsx");
                            workbook.SaveAs(@diretorio + "RelatorioDonoCao.xlsx");
                        }                        
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("SolicitaGeracaoRelatorio: " + ex.Message);
                return false;
            }
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

        public async Task<DonoCaoDto[]> ListarRelacionamentoDonoCaoPorRaca(string raca)
        {
            DonoCaoDto donoEcao = null;
            List<DonoCaoDto> relatorioDonoCao = null;

            var donos = await _geralRelatorioRepository.GetAllDono();
            var caes = await _geralRelatorioRepository.GetAllCao();

            relatorioDonoCao = new List<DonoCaoDto>();

            // Join cao and dono based on DonoId
            var query = from dono in donos
                        join cao in caes on dono.DonoId equals cao.DonoId
                        where cao.Raca == raca
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

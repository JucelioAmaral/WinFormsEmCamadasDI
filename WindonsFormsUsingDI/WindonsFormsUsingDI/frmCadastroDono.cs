using System;
using System.Windows.Forms;
using WindonsFormsUsingDI.Application;
using WindonsFormsUsingDI.Application.Contracts;
using WindonsFormsUsingDI.Application.Helpers;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI
{
    public partial class frmCadastroDono : Form
    {
        private readonly IDonoService _donoService;
        private readonly IGeralService _geralService;
        private string CPFSelecionado = "";
        Dono donoSelecionado;

        public frmCadastroDono(IDonoService donoService, IGeralService geralService)
        {
            InitializeComponent();
            _donoService = donoService;
            _geralService = geralService;
            CarregarGridView();
        }

        public async void CarregarGridView()
        {

            dgvDonoCao.DataSource = await _geralService.ListarRelacionamentoDonoCao();
            formataGridView(dgvDonoCao);            
        }
        private void formataGridView(DataGridView Dados)
        {
            var dgvDonoCao = Dados;
            dgvDonoCao.AutoGenerateColumns = false;
            dgvDonoCao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvDonoCao.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            dgvDonoCao.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvDonoCao.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Aquamarine;
            //altera o nome das colunas
            dgvDonoCao.Columns[0].HeaderText = "Nome do Dono";
            dgvDonoCao.Columns[1].HeaderText = "CPF";
            dgvDonoCao.Columns[2].HeaderText = "Telefone";
            dgvDonoCao.Columns[3].HeaderText = "Nome do Cão";
            dgvDonoCao.Columns[4].HeaderText = "Raça do Cão";
            //Largura das colunas
            dgvDonoCao.Columns[0].Width = 100;
            dgvDonoCao.Columns[1].Width = 100;
            dgvDonoCao.Columns[2].Width = 100;
            dgvDonoCao.Columns[3].Width = 100;
            dgvDonoCao.Columns[4].Width = 100;

            //esconde a coluna
            //gdvFunci.Columns[0].Visible = false;
            //gdvDonoCao.Columns[5].Visible = false;
            //seleciona a linha inteira
            dgvDonoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas
            dgvDonoCao.MultiSelect = false;
            // exibe nulos formatados
            dgvDonoCao.DefaultCellStyle.NullValue = " - ";
            //permite que o texto maior que célula não seja truncado
            dgvDonoCao.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private async void btnPesquisarPeloCPF_Click(object sender, EventArgs e)
        {            
            if (string.IsNullOrEmpty(mtxCPF.Text) || string.IsNullOrWhiteSpace(mtxCPF.Text))
            {
                MessageBox.Show("Campo CPF vazio", "Erro!");
            }
            else
            {
                string cpfDono = mtxCPF.Text;
                donoSelecionado = await _donoService.GetDono(cpfDono);
                if (donoSelecionado == null)
                {
                    string message = $"Não há Dono com este CPF {mtxCPF.Text} ou está errado.";
                    string caption = "Erro!";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
                else
                {
                    txtNomeDono.Text = donoSelecionado.NomeDono;
                    mtxCPF.Text = donoSelecionado.CPF;
                    mtxTelefone.Text = donoSelecionado.Telefone;

                    CPFSelecionado = donoSelecionado.CPF;
                    //http://www.macoratti.net/10/09/net_vgb1.htm
                    Global.NomeDoDonoFromfrmCadastroDono = donoSelecionado.NomeDono;
                    Global.IDdoDonoFromfrmCadastroDono = donoSelecionado.DonoId;
                }
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var d = new DonoDto()
            {
                NomeDono = txtNomeDono.Text,
                CPF = mtxCPF.Text,
                Telefone = mtxTelefone.Text
            };
            if (await _donoService.AddDono(d))
            {
                MessageBox.Show("Novo dono salvo com sucesso", "Sucesso!");
                CarregarGridView();
                clearFields();
            }
            else
            {
                clearFields();
                MessageBox.Show("Erro desconhecido ao salvar dono", "Erro!");
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtxCPF.Text))
            {
                MessageBox.Show("Campo CPF vazio", "Erro!");
            }
            else
            {
                var d = new DonoDto()
                {
                    NomeDono = txtNomeDono.Text,
                    CPF = mtxCPF.Text,
                    Telefone = mtxTelefone.Text
                };

                if (await _donoService.UpdateDono(CPFSelecionado, d))
                {
                    MessageBox.Show("Dono editado com sucesso", "Sucesso!");
                    CarregarGridView();
                    clearFields();
                }
                else
                {
                    clearFields();
                    MessageBox.Show("Erro desconhecido ao salvar dono", "Erro!");
                }
            }

            CPFSelecionado = "";
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtxCPF.Text))
            {
                MessageBox.Show("Campo CPF vazio", "Erro!");
            }
            else
            {
                if (await _donoService.DeleteDono(CPFSelecionado))
                {
                    MessageBox.Show("Dono excluído com sucesso", "Sucesso!");
                    CarregarGridView();
                    clearFields();
                }
                else
                {
                    clearFields();
                    MessageBox.Show("Erro desconhecido ao salvar dono", "Erro!");
                }
            }

            CPFSelecionado = "";
        }

        private void btnAtualizaCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mtxCPF.Text) || string.IsNullOrWhiteSpace(mtxCPF.Text))
            {
                MessageBox.Show("Primeiro pesquise o dono do cão(es)", "Erro!");
            }
            else
            {
                //https://pt.stackoverflow.com/questions/184157/d%C3%BAvida-sobre-como-implementar-uma-inje%C3%A7%C3%A3o-de-depend%C3%AAncia-no-c-utilizando-o-ninj
                frmCadastroCao frmCadCao = FormResolve.Resolve<frmCadastroCao>();
                frmCadCao.ShowDialog();
            }
        }
        public void clearFields()
        {
            txtNomeDono.Clear();
            mtxCPF.Clear();
            mtxTelefone.Clear();
        }

        private async void btnGerarRelatório_Click(object sender, EventArgs e)
        {
            string diretorio = "";
            try
            {
                // Preencher planilha excel/csv

                //var folderPath = @"E:\APLICAÇÕES E CURSOS\PROVA EDESOFT\ProvaEdesoft";
                //if (!Directory.Exists(folderPath))
                //    Directory.CreateDirectory(folderPath);
                //var filePath = $"{folderPath}\\YourFileName.xlsx";
                //Console.WriteLine($"Exported Successfully to {filePath}");

                //Define as propriedades do controle FolderBrowserDialog
                fbdDestino.Description = "Selecione uma pasta de destino:";
                this.fbdDestino.ShowNewFolderButton = true;
                //Exibe a caixa de diálogo
                this.fbdDestino.RootFolder = System.Environment.SpecialFolder.MyComputer;
                if (fbdDestino.ShowDialog() == DialogResult.OK)
                {
                    //Exibe a pasta selecionada
                    diretorio = fbdDestino.SelectedPath;
                    diretorio = diretorio + @"\";
                }
                if(await _geralService.GeraRelatório(txtInformeRacaCao.Text, diretorio))
                {
                    lblDiretorioDestino.Text = diretorio + "RelatorioDonoCao.xlsx";
                    MessageBox.Show("Relatório gerado no diretório informado.","Sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao gerar o Relatório.","Erro!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("btnGerarRelatório_Click: " + ex.Message);
            }
        }
    }
}

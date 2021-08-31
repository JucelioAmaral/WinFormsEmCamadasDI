using System;
using System.Windows.Forms;
using WindonsFormsUsingDI.Application.Contracts;
using WindonsFormsUsingDI.Application.Dtos;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI
{
    public partial class frmCadastroCao : Form
    {
        private readonly ICaoService _caoService;
        private readonly IGeralService _geralService;

        //CaoDto caoSelecionado;
        Cao caoSelecionado;
        public int IDDonoSelecionado;
        public int IDCaoSelecioonado;

        public frmCadastroCao(ICaoService caoService, IGeralService geralService)
        {
            InitializeComponent();
            _caoService = caoService;
            _geralService = geralService;
            txtNomeDono.Text = Global.NomeDoDonoFromfrmCadastroDono;
            IDDonoSelecionado = Global.IDdoDonoFromfrmCadastroDono;
        }

        private async void btnPesquisarPeloNomeDoCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCao.Text) || string.IsNullOrWhiteSpace(txtNomeCao.Text))
            {
                MessageBox.Show("Campo Nome do Cão está vazio", "Erro!");
            }
            else
            {
                caoSelecionado = await _caoService.GetCaoByNomeCao(txtNomeCao.Text, IDDonoSelecionado);
                if (caoSelecionado == null)
                {
                    string message = $"Não há cão para este Dono ou o cão {txtNomeCao.Text} não pertence a este dono.";
                    string caption = "Erro!";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
                else
                {
                    txtRacaCao.Text = caoSelecionado.Raca;
                    IDCaoSelecioonado = caoSelecionado.CaoId;
                }
            }
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            var d = new CaoDto()
            {
                NomeCao = txtNomeCao.Text,
                Raca = txtRacaCao.Text
            };
            if (await _caoService.AddCao(IDDonoSelecionado, d))
            {
                MessageBox.Show("Cão salvo com sucesso", "Sucesso!");
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
            var d = new CaoDto()
            {
                NomeCao = txtNomeCao.Text,
                Raca = txtRacaCao.Text
            };
            if (await _caoService.UpdateCao(IDCaoSelecioonado, d))
            {
                MessageBox.Show("Cão editado com sucesso", "Sucesso!");
                clearFields();
            }
            else
            {
                clearFields();
                MessageBox.Show("Erro desconhecido ao salvar dono", "Erro!");
            }
            IDCaoSelecioonado = 0;
        }

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCao.Text))
            {
                MessageBox.Show("Campo Nome Cão está vazio");
            }
            else
            {
                if (await _caoService.DeleteCao(IDCaoSelecioonado))
                {
                    MessageBox.Show("Dono excluído com sucesso","Sucesso!");
                    clearFields();
                }
                else
                {
                    clearFields();
                    MessageBox.Show("Erro desconhecido ao salvar dono","Erro!");
                }
            }

            IDCaoSelecioonado = 0;
        }

        public void clearFields()
        {
            txtNomeDono.Clear();
            txtNomeCao.Clear();
            txtRacaCao.Clear();
        }
    }
}

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

        CaoDto caoSelecionado;
        public int IDDono;

        public frmCadastroCao(ICaoService caoService, IGeralService geralService)
        {
            InitializeComponent();
            _caoService = caoService;
            _geralService = geralService;
            txtNomeDono.Text = Global.NomeDoDonoFromfrmCadastroDono;
            IDDono = Global.IDdoDonoFromfrmCadastroDono;
        }

        private void btnPesquisarPeloNomeDoCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCao.Text) || string.IsNullOrWhiteSpace(txtNomeCao.Text))
            {
                MessageBox.Show("Campo Nome do Cão está vazio");
            }
            else
            {
                caoSelecionado = _caoService.GetCaoByNomeCao(txtNomeCao.Text);
                if (caoSelecionado.NomeCao == "")
                {
                    MessageBox.Show("Não há cão com este nome.");
                }
                else
                {
                    txtRacaCao.Text = caoSelecionado.Raca;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var d = new CaoDto()
            {
                NomeCao = txtNomeCao.Text,
                Raca = txtRacaCao.Text
            };
            if (_caoService.AddCao(IDDono, d))
            {
                MessageBox.Show("Cão salvo com sucesso");
                clearFields();
            }
            else
            {
                clearFields();
                MessageBox.Show("Erro desconhecido ao salvar dono");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        public void clearFields()
        {
            txtNomeDono.Clear();
            txtNomeCao.Clear();
            txtRacaCao.Clear();
        }
    }
}

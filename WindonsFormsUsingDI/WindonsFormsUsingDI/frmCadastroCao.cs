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

        private void btnPesquisarPeloNomeDoCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCao.Text) || string.IsNullOrWhiteSpace(txtNomeCao.Text))
            {
                MessageBox.Show("Campo Nome do Cão está vazio", "Erro!");
            }
            else
            {
                caoSelecionado = _caoService.GetCaoByNomeCao(txtNomeCao.Text);
                if (caoSelecionado.NomeCao == "")
                {
                    MessageBox.Show("Não há cão com este nome.", "Erro!");
                }
                else
                {
                    txtRacaCao.Text = caoSelecionado.Raca;
                    IDCaoSelecioonado = caoSelecionado.CaoId;
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
            if (_caoService.AddCao(IDDonoSelecionado, d))
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var d = new CaoDto()
            {
                NomeCao = txtNomeCao.Text,
                Raca = txtRacaCao.Text
            };
            if (_caoService.UpdateCao(IDCaoSelecioonado, d))
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeCao.Text))
            {
                MessageBox.Show("Campo Nome Cão está vazio");
            }
            else
            {
                if (_caoService.DeleteCao(IDCaoSelecioonado))
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

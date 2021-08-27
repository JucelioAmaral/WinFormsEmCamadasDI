using System;
using System.Windows.Forms;
using WindonsFormsUsingDI.Application;
using WindonsFormsUsingDI.Application.Contratos;
using WindonsFormsUsingDI.Application.Helpers;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI
{
    public partial class frmCadastroDono : Form
    {
        private readonly IDonoService _donoService;
        private int idSelecionado = 0;
        DonoDto donoSelecionado;

        public frmCadastroDono(IDonoService donoService)
        {
            InitializeComponent();
            _donoService = donoService;

            //IMPLEMENTAR PARA CARREGAR O DATAGRIDVIEW.
            //dvgDonoCao.DataSource = _geralService.GetAll();
        }

        private void btnPesquisarPeloCPF_Click(object sender, EventArgs e)
        {
            string cpfDono = txtCPFDono.Text;
            donoSelecionado = _donoService.GetDono(cpfDono);
            txtNomeDono.Text = donoSelecionado.NomeDono;
            txtCPFDono.Text = donoSelecionado.CPF;
            txtTelefoneDono.Text = donoSelecionado.Telefone;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var d = new Dono()
            {
                NomeDono = txtNomeDono.Text,
                CPF = txtCPFDono.Text,
                Telefone = txtTelefoneDono.Text
            };
            if (_donoService.AddDono(d))
            {
                MessageBox.Show("Novo dono salvo com sucesso");
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
            var d = new Dono()
            {
                NomeDono = txtNomeDono.Text,
                CPF = txtCPFDono.Text,
                Telefone = txtTelefoneDono.Text
            };
            if (_donoService.UpdateDono(idSelecionado, d))
            {
                MessageBox.Show("Novo dono salvo com sucesso");
                clearFields();
            }
            else
            {
                clearFields();
                MessageBox.Show("Erro desconhecido ao salvar dono");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            frmExcluirRegistro frmCadCao = FormResolve.Resolve<frmExcluirRegistro>();
            frmCadCao.ShowDialog();
        }

        private void btnCadastrarSeuCao_Click(object sender, EventArgs e)
        {
            //https://pt.stackoverflow.com/questions/184157/d%C3%BAvida-sobre-como-implementar-uma-inje%C3%A7%C3%A3o-de-depend%C3%AAncia-no-c-utilizando-o-ninj
            frmCadastroCao frmCadCao = FormResolve.Resolve<frmCadastroCao>();
            frmCadCao.ShowDialog();
        }
        public void clearFields()
        {
            txtNomeDono.Clear();
            txtCPFDono.Clear();
            txtTelefoneDono.Clear();
        }
    }
}

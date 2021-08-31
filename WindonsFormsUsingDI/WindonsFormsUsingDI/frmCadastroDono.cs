﻿using System;
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

            //IMPLEMENTAR PARA CARREGAR O DATAGRIDVIEW.
            //dvgDonoCao.DataSource = _geralService.GetAll();
        }

        private void btnPesquisarPeloCPF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPFDono.Text) || string.IsNullOrWhiteSpace(txtCPFDono.Text))
            {
                MessageBox.Show("Campo CPF vazio");
            }
            else
            {
                string cpfDono = txtCPFDono.Text;
                donoSelecionado = _donoService.GetDono(cpfDono);

                txtNomeDono.Text = donoSelecionado.NomeDono;
                txtCPFDono.Text = donoSelecionado.CPF;
                txtTelefoneDono.Text = donoSelecionado.Telefone;
                
                CPFSelecionado = donoSelecionado.CPF;
                //http://www.macoratti.net/10/09/net_vgb1.htm
                Global.NomeDoDonoFromfrmCadastroDono = donoSelecionado.NomeDono;
                Global.IDdoDonoFromfrmCadastroDono = donoSelecionado.DonoId;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var d = new DonoDto()
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
            if (string.IsNullOrEmpty(txtCPFDono.Text))
            {
                MessageBox.Show("Campo CPF vazio");
            }
            else
            {
                var d = new DonoDto()
                {
                    NomeDono = txtNomeDono.Text,
                    CPF = txtCPFDono.Text,
                    Telefone = txtTelefoneDono.Text
                };

                if (_donoService.UpdateDono(CPFSelecionado, d))
                {
                    MessageBox.Show("Dono editado com sucesso");
                    clearFields();
                }
                else
                {
                    clearFields();
                    MessageBox.Show("Erro desconhecido ao salvar dono");
                }
            }

            CPFSelecionado = "";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPFDono.Text))
            {
                MessageBox.Show("Campo CPF vazio");
            }
            else
            {
                if (_donoService.DeleteDono(CPFSelecionado))
                {
                    MessageBox.Show("Dono excluído com sucesso");
                    clearFields();
                }
                else
                {
                    clearFields();
                    MessageBox.Show("Erro desconhecido ao salvar dono");
                }
            }

            CPFSelecionado = "";
        }

        private void btnCadastrarSeuCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCPFDono.Text) || string.IsNullOrWhiteSpace(txtCPFDono.Text))
            {
                MessageBox.Show("Primeiro pesquise o dono do cão(es)");
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
            txtCPFDono.Clear();
            txtTelefoneDono.Clear();
        }
    }
}

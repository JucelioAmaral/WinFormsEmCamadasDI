
namespace WindonsFormsUsingDI
{
    partial class frmCadastroDono
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDonoCao = new System.Windows.Forms.DataGridView();
            this.btnPesquisarPeloCPF = new System.Windows.Forms.Button();
            this.btnCadastrarSeuCao = new System.Windows.Forms.Button();
            this.txtNomeDono = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDiretorioDestino = new System.Windows.Forms.Label();
            this.btnGerarRelatório = new System.Windows.Forms.Button();
            this.txtInformeRacaCao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRacaDoCao = new System.Windows.Forms.Label();
            this.lblNomeCao = new System.Windows.Forms.Label();
            this.lblNomeDoDono = new System.Windows.Forms.Label();
            this.fbdDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonoCao)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgDonoCao
            // 
            this.dgvDonoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonoCao.Location = new System.Drawing.Point(25, 222);
            this.dgvDonoCao.Name = "dvgDonoCao";
            this.dgvDonoCao.Size = new System.Drawing.Size(528, 285);
            this.dgvDonoCao.TabIndex = 5;
            // 
            // btnPesquisarPeloCPF
            // 
            this.btnPesquisarPeloCPF.Location = new System.Drawing.Point(6, 145);
            this.btnPesquisarPeloCPF.Name = "btnPesquisarPeloCPF";
            this.btnPesquisarPeloCPF.Size = new System.Drawing.Size(109, 23);
            this.btnPesquisarPeloCPF.TabIndex = 12;
            this.btnPesquisarPeloCPF.Text = "Pesquisar pelo CPF";
            this.btnPesquisarPeloCPF.UseVisualStyleBackColor = true;
            this.btnPesquisarPeloCPF.Click += new System.EventHandler(this.btnPesquisarPeloCPF_Click);
            // 
            // btnCadastrarSeuCao
            // 
            this.btnCadastrarSeuCao.Location = new System.Drawing.Point(398, 145);
            this.btnCadastrarSeuCao.Name = "btnCadastrarSeuCao";
            this.btnCadastrarSeuCao.Size = new System.Drawing.Size(109, 23);
            this.btnCadastrarSeuCao.TabIndex = 10;
            this.btnCadastrarSeuCao.Text = "Cadastrar seu Cão";
            this.btnCadastrarSeuCao.UseVisualStyleBackColor = true;
            this.btnCadastrarSeuCao.Click += new System.EventHandler(this.btnCadastrarSeuCao_Click);
            // 
            // txtNomeDono
            // 
            this.txtNomeDono.Location = new System.Drawing.Point(117, 29);
            this.txtNomeDono.Name = "txtNomeDono";
            this.txtNomeDono.Size = new System.Drawing.Size(390, 20);
            this.txtNomeDono.TabIndex = 7;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(288, 145);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(207, 145);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(126, 145);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDiretorioDestino
            // 
            this.lblDiretorioDestino.AutoSize = true;
            this.lblDiretorioDestino.Location = new System.Drawing.Point(6, 51);
            this.lblDiretorioDestino.Name = "lblDiretorioDestino";
            this.lblDiretorioDestino.Size = new System.Drawing.Size(0, 13);
            this.lblDiretorioDestino.TabIndex = 11;
            // 
            // btnGerarRelatório
            // 
            this.btnGerarRelatório.Location = new System.Drawing.Point(368, 19);
            this.btnGerarRelatório.Name = "btnGerarRelatório";
            this.btnGerarRelatório.Size = new System.Drawing.Size(139, 27);
            this.btnGerarRelatório.TabIndex = 10;
            this.btnGerarRelatório.Text = "Gerar relatório";
            this.btnGerarRelatório.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGerarRelatório.UseVisualStyleBackColor = true;
            this.btnGerarRelatório.Click += new System.EventHandler(this.btnGerarRelatório_Click);
            // 
            // txtInformeRacaCao
            // 
            this.txtInformeRacaCao.Location = new System.Drawing.Point(123, 25);
            this.txtInformeRacaCao.Name = "txtInformeRacaCao";
            this.txtInformeRacaCao.Size = new System.Drawing.Size(214, 20);
            this.txtInformeRacaCao.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Informe a raça do cão:";
            // 
            // lblRacaDoCao
            // 
            this.lblRacaDoCao.AutoSize = true;
            this.lblRacaDoCao.Location = new System.Drawing.Point(21, 99);
            this.lblRacaDoCao.Name = "lblRacaDoCao";
            this.lblRacaDoCao.Size = new System.Drawing.Size(96, 13);
            this.lblRacaDoCao.TabIndex = 2;
            this.lblRacaDoCao.Text = "Telefone do Dono:";
            // 
            // lblNomeCao
            // 
            this.lblNomeCao.AutoSize = true;
            this.lblNomeCao.Location = new System.Drawing.Point(21, 64);
            this.lblNomeCao.Name = "lblNomeCao";
            this.lblNomeCao.Size = new System.Drawing.Size(74, 13);
            this.lblNomeCao.TabIndex = 1;
            this.lblNomeCao.Text = "CPF do Dono:";
            // 
            // lblNomeDoDono
            // 
            this.lblNomeDoDono.AutoSize = true;
            this.lblNomeDoDono.Location = new System.Drawing.Point(19, 32);
            this.lblNomeDoDono.Name = "lblNomeDoDono";
            this.lblNomeDoDono.Size = new System.Drawing.Size(77, 13);
            this.lblNomeDoDono.TabIndex = 0;
            this.lblNomeDoDono.Text = "Nome do dono";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDiretorioDestino);
            this.groupBox2.Controls.Add(this.btnGerarRelatório);
            this.groupBox2.Controls.Add(this.txtInformeRacaCao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(25, 513);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerar relatório";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtxTelefone);
            this.groupBox1.Controls.Add(this.mtxCPF);
            this.groupBox1.Controls.Add(this.btnPesquisarPeloCPF);
            this.groupBox1.Controls.Add(this.btnCadastrarSeuCao);
            this.groupBox1.Controls.Add(this.txtNomeDono);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.lblRacaDoCao);
            this.groupBox1.Controls.Add(this.lblNomeCao);
            this.groupBox1.Controls.Add(this.lblNomeDoDono);
            this.groupBox1.Location = new System.Drawing.Point(25, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro dos Donos";
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(117, 61);
            this.mtxCPF.Mask = "000.000.000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(84, 20);
            this.mtxCPF.TabIndex = 13;
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Location = new System.Drawing.Point(117, 96);
            this.mtxTelefone.Mask = "(00)0000-0000";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(84, 20);
            this.mtxTelefone.TabIndex = 14;
            // 
            // frmCadastroDono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 619);
            this.Controls.Add(this.dgvDonoCao);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastroDono";
            this.Text = "CADASTRO DE DONO E SEU CÃO";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonoCao)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDonoCao;
        private System.Windows.Forms.Button btnPesquisarPeloCPF;
        private System.Windows.Forms.Button btnCadastrarSeuCao;
        private System.Windows.Forms.TextBox txtNomeDono;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDiretorioDestino;
        private System.Windows.Forms.Button btnGerarRelatório;
        private System.Windows.Forms.TextBox txtInformeRacaCao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRacaDoCao;
        private System.Windows.Forms.Label lblNomeCao;
        private System.Windows.Forms.Label lblNomeDoDono;
        private System.Windows.Forms.FolderBrowserDialog fbdDestino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
    }
}


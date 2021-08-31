
namespace WindonsFormsUsingDI
{
    partial class frmCadastroCao
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
            this.txtRacaCao = new System.Windows.Forms.TextBox();
            this.txtNomeCao = new System.Windows.Forms.TextBox();
            this.txtNomeDono = new System.Windows.Forms.TextBox();
            this.lblRacaDoCao = new System.Windows.Forms.Label();
            this.lblNomeCao = new System.Windows.Forms.Label();
            this.lblNomeDoDono = new System.Windows.Forms.Label();
            this.btnPesquisarPeloNomeDoCao = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRacaCao
            // 
            this.txtRacaCao.Location = new System.Drawing.Point(97, 71);
            this.txtRacaCao.Name = "txtRacaCao";
            this.txtRacaCao.Size = new System.Drawing.Size(471, 20);
            this.txtRacaCao.TabIndex = 30;
            // 
            // txtNomeCao
            // 
            this.txtNomeCao.Location = new System.Drawing.Point(97, 45);
            this.txtNomeCao.Name = "txtNomeCao";
            this.txtNomeCao.Size = new System.Drawing.Size(471, 20);
            this.txtNomeCao.TabIndex = 29;
            // 
            // txtNomeDono
            // 
            this.txtNomeDono.Enabled = false;
            this.txtNomeDono.Location = new System.Drawing.Point(97, 17);
            this.txtNomeDono.Name = "txtNomeDono";
            this.txtNomeDono.Size = new System.Drawing.Size(471, 20);
            this.txtNomeDono.TabIndex = 28;
            // 
            // lblRacaDoCao
            // 
            this.lblRacaDoCao.AutoSize = true;
            this.lblRacaDoCao.Location = new System.Drawing.Point(16, 74);
            this.lblRacaDoCao.Name = "lblRacaDoCao";
            this.lblRacaDoCao.Size = new System.Drawing.Size(73, 13);
            this.lblRacaDoCao.TabIndex = 27;
            this.lblRacaDoCao.Text = "Raça do Cão:";
            // 
            // lblNomeCao
            // 
            this.lblNomeCao.AutoSize = true;
            this.lblNomeCao.Location = new System.Drawing.Point(16, 45);
            this.lblNomeCao.Name = "lblNomeCao";
            this.lblNomeCao.Size = new System.Drawing.Size(75, 13);
            this.lblNomeCao.TabIndex = 26;
            this.lblNomeCao.Text = "Nome do Cão:";
            // 
            // lblNomeDoDono
            // 
            this.lblNomeDoDono.AutoSize = true;
            this.lblNomeDoDono.Location = new System.Drawing.Point(16, 20);
            this.lblNomeDoDono.Name = "lblNomeDoDono";
            this.lblNomeDoDono.Size = new System.Drawing.Size(82, 13);
            this.lblNomeDoDono.TabIndex = 25;
            this.lblNomeDoDono.Text = "Nome do Dono:";
            // 
            // btnPesquisarPeloNomeDoCao
            // 
            this.btnPesquisarPeloNomeDoCao.Location = new System.Drawing.Point(94, 106);
            this.btnPesquisarPeloNomeDoCao.Name = "btnPesquisarPeloNomeDoCao";
            this.btnPesquisarPeloNomeDoCao.Size = new System.Drawing.Size(164, 23);
            this.btnPesquisarPeloNomeDoCao.TabIndex = 34;
            this.btnPesquisarPeloNomeDoCao.Text = "Pesquisar pelo nome do cão";
            this.btnPesquisarPeloNomeDoCao.UseVisualStyleBackColor = true;
            this.btnPesquisarPeloNomeDoCao.Click += new System.EventHandler(this.btnPesquisarPeloNomeDoCao_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(493, 106);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(412, 106);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(331, 106);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCadastroCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 157);
            this.Controls.Add(this.btnPesquisarPeloNomeDoCao);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtRacaCao);
            this.Controls.Add(this.txtNomeCao);
            this.Controls.Add(this.txtNomeDono);
            this.Controls.Add(this.lblRacaDoCao);
            this.Controls.Add(this.lblNomeCao);
            this.Controls.Add(this.lblNomeDoDono);
            this.Name = "frmCadastroCao";
            this.Text = "CADASTRO DO CÃO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRacaCao;
        private System.Windows.Forms.TextBox txtNomeCao;
        private System.Windows.Forms.TextBox txtNomeDono;
        private System.Windows.Forms.Label lblRacaDoCao;
        private System.Windows.Forms.Label lblNomeCao;
        private System.Windows.Forms.Label lblNomeDoDono;
        private System.Windows.Forms.Button btnPesquisarPeloNomeDoCao;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
    }
}
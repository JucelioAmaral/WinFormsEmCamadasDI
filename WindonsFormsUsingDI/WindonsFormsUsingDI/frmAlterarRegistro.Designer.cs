
namespace WindonsFormsUsingDI
{
    partial class frmAlterarRegistro
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtRacaCao = new System.Windows.Forms.TextBox();
            this.txtNomeCao = new System.Windows.Forms.TextBox();
            this.txtNomeDono = new System.Windows.Forms.TextBox();
            this.lblRacaDoCao = new System.Windows.Forms.Label();
            this.lblNomeCao = new System.Windows.Forms.Label();
            this.lblNomeDoDono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(207, 127);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 31;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(110, 127);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 30;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtRacaCao
            // 
            this.txtRacaCao.Location = new System.Drawing.Point(110, 90);
            this.txtRacaCao.Name = "txtRacaCao";
            this.txtRacaCao.Size = new System.Drawing.Size(471, 20);
            this.txtRacaCao.TabIndex = 29;
            // 
            // txtNomeCao
            // 
            this.txtNomeCao.Location = new System.Drawing.Point(110, 51);
            this.txtNomeCao.Name = "txtNomeCao";
            this.txtNomeCao.Size = new System.Drawing.Size(471, 20);
            this.txtNomeCao.TabIndex = 28;
            // 
            // txtNomeDono
            // 
            this.txtNomeDono.Location = new System.Drawing.Point(110, 23);
            this.txtNomeDono.Name = "txtNomeDono";
            this.txtNomeDono.Size = new System.Drawing.Size(471, 20);
            this.txtNomeDono.TabIndex = 27;
            // 
            // lblRacaDoCao
            // 
            this.lblRacaDoCao.AutoSize = true;
            this.lblRacaDoCao.Location = new System.Drawing.Point(14, 93);
            this.lblRacaDoCao.Name = "lblRacaDoCao";
            this.lblRacaDoCao.Size = new System.Drawing.Size(70, 13);
            this.lblRacaDoCao.TabIndex = 26;
            this.lblRacaDoCao.Text = "Raça do Cão";
            // 
            // lblNomeCao
            // 
            this.lblNomeCao.AutoSize = true;
            this.lblNomeCao.Location = new System.Drawing.Point(12, 54);
            this.lblNomeCao.Name = "lblNomeCao";
            this.lblNomeCao.Size = new System.Drawing.Size(72, 13);
            this.lblNomeCao.TabIndex = 25;
            this.lblNomeCao.Text = "Nome do Cão";
            // 
            // lblNomeDoDono
            // 
            this.lblNomeDoDono.AutoSize = true;
            this.lblNomeDoDono.Location = new System.Drawing.Point(12, 26);
            this.lblNomeDoDono.Name = "lblNomeDoDono";
            this.lblNomeDoDono.Size = new System.Drawing.Size(77, 13);
            this.lblNomeDoDono.TabIndex = 24;
            this.lblNomeDoDono.Text = "Nome do dono";
            // 
            // frmAlterarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 175);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtRacaCao);
            this.Controls.Add(this.txtNomeCao);
            this.Controls.Add(this.txtNomeDono);
            this.Controls.Add(this.lblRacaDoCao);
            this.Controls.Add(this.lblNomeCao);
            this.Controls.Add(this.lblNomeDoDono);
            this.Name = "frmAlterarRegistro";
            this.Text = "ALTERAR CADASTROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtRacaCao;
        private System.Windows.Forms.TextBox txtNomeCao;
        private System.Windows.Forms.TextBox txtNomeDono;
        private System.Windows.Forms.Label lblRacaDoCao;
        private System.Windows.Forms.Label lblNomeCao;
        private System.Windows.Forms.Label lblNomeDoDono;
    }
}
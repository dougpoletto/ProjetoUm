namespace ProjetoUm
{
    partial class FormCadastroPessoa
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCpfCnpj = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.maskedTextBoxCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 12);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(368, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 38);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome:";
            // 
            // labelCpfCnpj
            // 
            this.labelCpfCnpj.AutoSize = true;
            this.labelCpfCnpj.Location = new System.Drawing.Point(12, 98);
            this.labelCpfCnpj.Name = "labelCpfCnpj";
            this.labelCpfCnpj.Size = new System.Drawing.Size(63, 15);
            this.labelCpfCnpj.TabIndex = 3;
            this.labelCpfCnpj.Text = "CPF/CNPJ:";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(12, 128);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 4;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // maskedTextBoxCpfCnpj
            // 
            this.maskedTextBoxCpfCnpj.Location = new System.Drawing.Point(12, 72);
            this.maskedTextBoxCpfCnpj.Name = "maskedTextBoxCpfCnpj";
            this.maskedTextBoxCpfCnpj.Size = new System.Drawing.Size(368, 23);
            this.maskedTextBoxCpfCnpj.TabIndex = 2;
            this.maskedTextBoxCpfCnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxCpfCnpj_KeyDown);
            this.maskedTextBoxCpfCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCpfCnpj_KeyPress);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(93, 128);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 5;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FormCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 163);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.maskedTextBoxCpfCnpj);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.labelCpfCnpj);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormCadastroPessoa";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private Label labelNome;
        private Label labelCpfCnpj;
        private Button buttonGravar;
        private MaskedTextBox maskedTextBoxCpfCnpj;
        private Button buttonCancelar;
    }
}
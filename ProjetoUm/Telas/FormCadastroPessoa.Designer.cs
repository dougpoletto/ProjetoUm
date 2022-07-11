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
            this.buttonPesquisaCep = new System.Windows.Forms.Button();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.labelCep = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.textBoxRgIe = new System.Windows.Forms.TextBox();
            this.labelRgIe = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxPessoa = new System.Windows.Forms.ComboBox();
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
            this.labelCpfCnpj.Location = new System.Drawing.Point(12, 90);
            this.labelCpfCnpj.Name = "labelCpfCnpj";
            this.labelCpfCnpj.Size = new System.Drawing.Size(63, 15);
            this.labelCpfCnpj.TabIndex = 3;
            this.labelCpfCnpj.Text = "CPF/CNPJ:";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(12, 327);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 21;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // maskedTextBoxCpfCnpj
            // 
            this.maskedTextBoxCpfCnpj.Location = new System.Drawing.Point(12, 64);
            this.maskedTextBoxCpfCnpj.Name = "maskedTextBoxCpfCnpj";
            this.maskedTextBoxCpfCnpj.Size = new System.Drawing.Size(200, 23);
            this.maskedTextBoxCpfCnpj.TabIndex = 2;
            this.maskedTextBoxCpfCnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxCpfCnpj_KeyDown);
            this.maskedTextBoxCpfCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxCpfCnpj_KeyPress);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(93, 327);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonPesquisaCep
            // 
            this.buttonPesquisaCep.Location = new System.Drawing.Point(116, 116);
            this.buttonPesquisaCep.Name = "buttonPesquisaCep";
            this.buttonPesquisaCep.Size = new System.Drawing.Size(102, 23);
            this.buttonPesquisaCep.TabIndex = 8;
            this.buttonPesquisaCep.Text = "Pesquisar CEP";
            this.buttonPesquisaCep.UseVisualStyleBackColor = true;
            this.buttonPesquisaCep.Click += new System.EventHandler(this.buttonPesquisaCep_Click);
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(12, 116);
            this.maskedTextBoxCep.Mask = "00000-000";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(98, 23);
            this.maskedTextBoxCep.TabIndex = 6;
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.Location = new System.Drawing.Point(12, 142);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(31, 15);
            this.labelCep.TabIndex = 7;
            this.labelCep.Text = "CEP:";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(12, 166);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(293, 23);
            this.textBoxEndereco.TabIndex = 9;
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(12, 217);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(200, 23);
            this.textBoxComplemento.TabIndex = 13;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(218, 217);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(162, 23);
            this.textBoxBairro.TabIndex = 15;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(12, 272);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(302, 23);
            this.textBoxCidade.TabIndex = 17;
            // 
            // textBoxRgIe
            // 
            this.textBoxRgIe.Location = new System.Drawing.Point(218, 64);
            this.textBoxRgIe.Name = "textBoxRgIe";
            this.textBoxRgIe.Size = new System.Drawing.Size(162, 23);
            this.textBoxRgIe.TabIndex = 4;
            // 
            // labelRgIe
            // 
            this.labelRgIe.AutoSize = true;
            this.labelRgIe.Location = new System.Drawing.Point(218, 90);
            this.labelRgIe.Name = "labelRgIe";
            this.labelRgIe.Size = new System.Drawing.Size(39, 15);
            this.labelRgIe.TabIndex = 5;
            this.labelRgIe.Text = "RG/IE:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(311, 166);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(69, 23);
            this.textBoxNumero.TabIndex = 11;
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(12, 192);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(59, 15);
            this.labelEndereco.TabIndex = 10;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(311, 192);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(54, 15);
            this.labelNumero.TabIndex = 12;
            this.labelNumero.Text = "Número:";
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(12, 243);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(87, 15);
            this.labelComplemento.TabIndex = 14;
            this.labelComplemento.Text = "Complemento:";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(218, 243);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(41, 15);
            this.labelBairro.TabIndex = 16;
            this.labelBairro.Text = "Bairro:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(12, 298);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(47, 15);
            this.labelCidade.TabIndex = 18;
            this.labelCidade.Text = "Cidade:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(320, 298);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(45, 15);
            this.labelEstado.TabIndex = 20;
            this.labelEstado.Text = "Estado:";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(320, 272);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(60, 23);
            this.comboBoxEstado.TabIndex = 19;
            // 
            // comboBoxPessoa
            // 
            this.comboBoxPessoa.FormattingEnabled = true;
            this.comboBoxPessoa.Location = new System.Drawing.Point(244, 117);
            this.comboBoxPessoa.Name = "comboBoxPessoa";
            this.comboBoxPessoa.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPessoa.TabIndex = 23;
            // 
            // FormCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 361);
            this.Controls.Add(this.comboBoxPessoa);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelRgIe);
            this.Controls.Add(this.textBoxRgIe);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.textBoxComplemento);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelCep);
            this.Controls.Add(this.maskedTextBoxCep);
            this.Controls.Add(this.buttonPesquisaCep);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.maskedTextBoxCpfCnpj);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.labelCpfCnpj);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormCadastroPessoa";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FormCadastroPessoa_Load);
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
        private Button buttonPesquisaCep;
        private MaskedTextBox maskedTextBoxCep;
        private Label labelCep;
        private TextBox textBoxEndereco;
        private TextBox textBoxComplemento;
        private TextBox textBoxBairro;
        private TextBox textBoxCidade;
        private TextBox textBoxRgIe;
        private Label labelRgIe;
        private TextBox textBoxNumero;
        private Label labelEndereco;
        private Label labelNumero;
        private Label labelComplemento;
        private Label labelBairro;
        private Label labelCidade;
        private Label labelEstado;
        private ComboBox comboBoxEstado;
        private ComboBox comboBoxPessoa;
    }
}
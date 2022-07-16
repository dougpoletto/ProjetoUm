namespace ProjetoUm.Telas
{
    partial class FormCadastroEstados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroEstados));
            this.dataGridViewEstados = new ProjetoUm.DataGridViewSistema();
            this.buttonCarregaEstado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEstados
            // 
            this.dataGridViewEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstados.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEstados.Name = "dataGridViewEstados";
            this.dataGridViewEstados.RowHeadersVisible = false;
            this.dataGridViewEstados.RowTemplate.Height = 25;
            this.dataGridViewEstados.Size = new System.Drawing.Size(217, 397);
            this.dataGridViewEstados.TabIndex = 0;
            // 
            // buttonCarregaEstado
            // 
            this.buttonCarregaEstado.Location = new System.Drawing.Point(121, 415);
            this.buttonCarregaEstado.Name = "buttonCarregaEstado";
            this.buttonCarregaEstado.Size = new System.Drawing.Size(108, 23);
            this.buttonCarregaEstado.TabIndex = 1;
            this.buttonCarregaEstado.Text = "Carregar Estados";
            this.buttonCarregaEstado.UseVisualStyleBackColor = true;
            this.buttonCarregaEstado.Click += new System.EventHandler(this.buttonCarregaEstado_Click);
            // 
            // FormCadastroEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 450);
            this.Controls.Add(this.buttonCarregaEstado);
            this.Controls.Add(this.dataGridViewEstados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastroEstados";
            this.Text = "Estados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewSistema dataGridViewEstados;
        private Button buttonCarregaEstado;
    }
}
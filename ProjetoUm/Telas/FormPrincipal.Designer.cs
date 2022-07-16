namespace ProjetoUm.Telas
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuArquivos = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuArquivos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuArquivos
            // 
            this.menuArquivos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuArquivos.Location = new System.Drawing.Point(0, 0);
            this.menuArquivos.Name = "menuArquivos";
            this.menuArquivos.Size = new System.Drawing.Size(1350, 24);
            this.menuArquivos.TabIndex = 0;
            this.menuArquivos.Text = "Menu";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.estadosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // estadosToolStripMenuItem
            // 
            this.estadosToolStripMenuItem.Name = "estadosToolStripMenuItem";
            this.estadosToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.estadosToolStripMenuItem.Text = "Estados";
            this.estadosToolStripMenuItem.Click += new System.EventHandler(this.estadosToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.menuArquivos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuArquivos;
            this.Name = "FormPrincipal";
            this.Text = "Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuArquivos.ResumeLayout(false);
            this.menuArquivos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuArquivos;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripMenuItem estadosToolStripMenuItem;
    }
}
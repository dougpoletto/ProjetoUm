using Microsoft.EntityFrameworkCore;
using System;

namespace ProjetoUm
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaGridCadastroPessoas();
        }

        private void CarregaGridCadastroPessoas()
        {
            using (var banco = new ContextoBancoDados(true))
            {
                try
                {
                    var pessoas = banco.CadastroPessoas
                        .FromSqlInterpolated($"select * from cadastropessoas")
                        .ToList();
                    dataGridViewPessoas.DataSource = pessoas;
                    dataGridViewPessoas.Columns[0].HeaderText = "Código";
                    dataGridViewPessoas.Columns[0].Width = 60;
                    dataGridViewPessoas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewPessoas.Columns[1].HeaderText = "Nome";
                    dataGridViewPessoas.Columns[1].Width = 180;
                    dataGridViewPessoas.Columns[2].HeaderText = "CPF/CNPJ";
                    dataGridViewPessoas.Columns[2].Width = 100;
                    dataGridViewPessoas.Columns[2].DefaultCellStyle.Format = "";
                    dataGridViewPessoas.Columns[3].HeaderText = "RG/IE";
                    dataGridViewPessoas.Columns[4].HeaderText = "Endereço";
                    dataGridViewPessoas.Columns[5].HeaderText = "Número";
                    dataGridViewPessoas.Columns[6].HeaderText = "Complemento";
                    dataGridViewPessoas.Columns[7].HeaderText = "Bairro";
                    dataGridViewPessoas.Columns[8].HeaderText = "Cidade";
                    dataGridViewPessoas.Columns[9].HeaderText = "Estado";
                    dataGridViewPessoas.Columns[10].HeaderText = "CEP";

                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Falha ao carregar os dados do cadastro de pessoas. Exceção: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gravar = new FormCadastroPessoa();
                gravar.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir a tela de inclusão. Erro: {ex.Message}", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdicionar_Leave(object sender, EventArgs e)
        {
            CarregaGridCadastroPessoas();
        }
    }
}
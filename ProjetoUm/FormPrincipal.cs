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
                        .FromSqlRaw("select * from cadastropessoas")
                        .ToList();
                    dataGridViewPessoas.AutoGenerateColumns = false;
                    dataGridViewPessoas.AutoSize = false;
                    dataGridViewPessoas.DataSource = pessoas;

                    FormatarColunaDataGrid("Id", "Id", 60, "Código", DataGridViewContentAlignment.MiddleCenter);
                    FormatarColunaDataGrid("Nome", "Nome", 180, "Nome", DataGridViewContentAlignment.MiddleLeft);
                    FormatarColunaDataGrid("CpfCnpj", "CpfCnpj", 120, "CPF/CNPJ", DataGridViewContentAlignment.MiddleLeft);
                    FormatarColunaDataGrid("RgIe", "RgIe", 100, "RG/IE", DataGridViewContentAlignment.MiddleLeft);
                    FormatarColunaDataGrid("Endereco", "Endereco", 200, "Endereço", DataGridViewContentAlignment.MiddleLeft);
                    FormatarColunaDataGrid("Numero", "Numero", 60, "Número", DataGridViewContentAlignment.MiddleCenter);
                    FormatarColunaDataGrid("Complemento", "Complemento", 150, "Complemento", DataGridViewContentAlignment.MiddleLeft);
                    FormatarColunaDataGrid("Bairro", "Bairro", 150, "Bairro", DataGridViewContentAlignment.MiddleLeft);
                    FormatarColunaDataGrid("Cidade", "Cidade", 150, "Cidade", DataGridViewContentAlignment.MiddleLeft);
                    FormatarColunaDataGrid("Estado", "Estado", 100, "Estado", DataGridViewContentAlignment.MiddleLeft);
                    FormatarColunaDataGrid("Cep", "Cep", 80, "CEP", DataGridViewContentAlignment.MiddleCenter);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Falha ao carregar os dados do cadastro de pessoas. Exceção: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormatarColunaDataGrid(string dataPropertyName, string name, int width, string headerText, 
            DataGridViewContentAlignment alignment)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = dataPropertyName;
            column.Name = name;
            column.Width = width;
            column.HeaderText = headerText;
            column.DefaultCellStyle.Alignment = alignment;
            column.Resizable = DataGridViewTriState.False;
            dataGridViewPessoas.Columns.Add(column);
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var gravar = new FormCadastroPessoa();
                gravar.ShowDialog();
                CarregaGridCadastroPessoas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir a tela de inclusão. Erro: {ex.Message}", 
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            using (var banco = new ContextoBancoDados(true))
            {
                try
                {
                    int id = int.Parse(dataGridViewPessoas.CurrentRow.Cells["Id"].Value.ToString());
                    if (id != 0)
                    {
                        MessageBox.Show("Não existe registro para excluir!",
                            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        var pessoas = banco.CadastroPessoas
                            .Where(x => x.Id == id)
                            .FirstOrDefault();
                        banco.CadastroPessoas
                            .Remove(pessoas);
                        banco.SaveChanges();

                        CarregaGridCadastroPessoas();
                    }
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Não existe registro para excluir!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir o registro. Erro: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
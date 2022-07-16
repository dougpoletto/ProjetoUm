using Microsoft.EntityFrameworkCore;
using ProjetoUm.Classes;
using ProjetoUm.Contexto;

namespace ProjetoUm.Telas
{
    public partial class FormlCadastroPessoasLista : Form
    {
        public FormlCadastroPessoasLista()
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
                        .ToList();
                    dataGridViewPessoas.AutoGenerateColumns = false;
                    dataGridViewPessoas.AutoSize = false;
                    dataGridViewPessoas.Columns.Clear();
                    dataGridViewPessoas.DataSource = pessoas;

                    FormatarDataGrid.FormatarColunaDataGrid("Id", "Id", 60, "Código", 
                        DataGridViewContentAlignment.MiddleCenter, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("Nome", "Nome", 180, "Nome", 
                        DataGridViewContentAlignment.MiddleLeft, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("CpfCnpj", "CpfCnpj", 120, "CPF/CNPJ", 
                        DataGridViewContentAlignment.MiddleLeft, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("RgIe", "RgIe", 100, "RG/IE", 
                        DataGridViewContentAlignment.MiddleLeft, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("Endereco", "Endereco", 200, "Endereço", 
                        DataGridViewContentAlignment.MiddleLeft, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("Numero", "Numero", 60, "Número", 
                        DataGridViewContentAlignment.MiddleCenter, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("Complemento", "Complemento", 150, "Complemento", 
                        DataGridViewContentAlignment.MiddleLeft, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("Bairro", "Bairro", 150, "Bairro", 
                        DataGridViewContentAlignment.MiddleLeft, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("Cidade", "Cidade", 150, "Cidade", 
                        DataGridViewContentAlignment.MiddleLeft, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("Estado", "Estado", 100, "Estado", 
                        DataGridViewContentAlignment.MiddleLeft, dataGridViewPessoas);
                    FormatarDataGrid.FormatarColunaDataGrid("Cep", "Cep", 80, "CEP", 
                        DataGridViewContentAlignment.MiddleCenter, dataGridViewPessoas);
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
                var gravar = new FormCadastroPessoaDados("Adicionar", 0);
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
                        DialogResult dialogResult = MessageBox.Show("Confirma exclusão do registro selecionado!",
                            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.Yes)
                        {
                            var pessoas = banco.CadastroPessoas
                                .Where(x => x.Id == id)
                                .FirstOrDefault();
                            banco.CadastroPessoas
                                .Remove(pessoas);
                            banco.SaveChanges();
                        }
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
            using (var banco = new ContextoBancoDados())
            {
                try
                {
                    int id = int.Parse(dataGridViewPessoas.CurrentRow.Cells["Id"].Value.ToString());
                    if (id != 0)
                    {
                        var pessoa = banco.CadastroPessoas
                            .Where(x => x.Id == id)
                            .FirstOrDefault();
                        var form = new FormCadastroPessoaDados("Modificar", id);
                        form.ShowDialog();
                        CarregaGridCadastroPessoas();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show($"Falha ao alterar o registro. Erro: {ex.Message}!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

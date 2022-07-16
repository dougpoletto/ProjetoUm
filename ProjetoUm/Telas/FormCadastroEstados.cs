using Microsoft.EntityFrameworkCore;
using ProjetoUm.Classes;
using ProjetoUm.Contexto;
using ProjetoUm.Entidades;

namespace ProjetoUm.Telas
{
    public partial class FormCadastroEstados : Form
    {
        public FormCadastroEstados()
        {
            InitializeComponent();
            CarreaDataGridEstados();
        }

        private void CarreaDataGridEstados()
        {
            using (var banco = new ContextoBancoDados())
            {
                var estados = banco.CadastroEstado
                    .ToList();
                dataGridViewEstados.AutoGenerateColumns = false;
                dataGridViewEstados.AutoSize = false;
                dataGridViewEstados.Columns.Clear();
                dataGridViewEstados.DataSource = estados;

                FormatarDataGrid.FormatarColunaDataGrid("Estado", "Estado", 50, "UF",
                    DataGridViewContentAlignment.MiddleCenter, dataGridViewEstados);
                FormatarDataGrid.FormatarColunaDataGrid("NomeEstado", "NomeEstado", 150, "Estado",
                    DataGridViewContentAlignment.MiddleLeft, dataGridViewEstados);
            }
        }

        private async void buttonCarregaEstado_Click(object sender, EventArgs e)
        {
            if (dataGridViewEstados.Rows.Count != 0)
            {
                MessageBox.Show("Estados já cadastrados!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    var dados = await ConsultarEstado.ConsultaEstado();

                    using (var banco = new ContextoBancoDados(false))
                    {
                        foreach (var estado in dados)
                        {
                            banco.Add(new CadastroEstado() {
                                Estado = estado.Sigla.Trim(),
                                NomeEstado = estado.Nome.Trim()
                            });
                            banco.SaveChanges();
                        }
                    }
                    CarreaDataGridEstados();
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Falha na gravação dos estados. Exceção: {ex.Message}",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

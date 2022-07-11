namespace ProjetoUm
{
    public class DataGridViewSistema : DataGridView
    {
        public DataGridViewSistema()
        {
        }
    }

    public class DataGridViewColumnSistema : DataGridViewColumn
    {
        public DataGridViewColumn Coluna { get; set; } = new DataGridViewColumn();
        /*public DataGridViewColumnSistema(DataGridView dataGridView, string cabecalho, string propriedadeNome, 
            string nome, int tamanho, DataGridViewContentAlignment alinhamento) : base()*/
        public DataGridViewColumnSistema() : base()
        {
        }
        public DataGridViewColumnSistema(string cabecalho, string propriedadeNome,
            string nome, int tamanho, DataGridViewContentAlignment alinhamento, DataGridView dataGridView) : base()
        {
            Coluna.HeaderText = cabecalho;
            Coluna.DataPropertyName = propriedadeNome;
            Coluna.Name = nome;
            Coluna.Width = tamanho;
            Coluna.DefaultCellStyle.Alignment = alinhamento;
            dataGridView.Columns.Add(Coluna);
        }
    }
}

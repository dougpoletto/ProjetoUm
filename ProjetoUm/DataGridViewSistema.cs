namespace ProjetoUm
{
    public class DataGridViewSistema : DataGridView
    {
        public DataGridViewSistema()
        {
        }

        public DataGridViewSistema(object dataSource)
        {
            DataSource = dataSource;
        }
    }

    public class DataGridViewColumnSistema : DataGridViewColumn
    {
        public DataGridViewColumnSistema()
        {
        }

        public DataGridViewColumnSistema(DataGridViewColumn dataGridViewColumn)
        {
        }
    }
}

namespace ProjetoUm.Classes
{
    public static class FormatarDataGrid
    {
        public static void FormatarColunaDataGrid(string dataPropertyName, string name, int width, string headerText,
            DataGridViewContentAlignment alignment, DataGridView dataGridView)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = dataPropertyName;
            column.Name = name;
            column.Width = width;
            column.HeaderText = headerText;
            column.DefaultCellStyle.Alignment = alignment;
            column.Resizable = DataGridViewTriState.False;
            dataGridView.Columns.Add(column);
        }
    }
}

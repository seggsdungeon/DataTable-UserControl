using System.Collections.ObjectModel;
using Microsoft.UI.Xaml.Controls;
using TableModuleTestApplication.DataTable.Models;

namespace TableModuleTestApplication.DataTable.Views
{
    public sealed partial class DataTable : UserControl
    {
        public ObservableCollection<TableColumn> Columns { get; set; } = new();

        public DataTable()
        {
            this.InitializeComponent();
        }

        public void InitializeTable(int rowCount, int columnCount)
        {
            Columns.Clear();

            for (int col = 0; col < columnCount; col++)
            {
                var column = new TableColumn
                {
                    Header = $"Column {col + 1}",
                    Type = ColumnType.TextBox
                };

                for (int row = 0; row < rowCount; row++)
                {
                    column.Values.Add($"R{row}C{col}");
                }

                Columns.Add(column);
            }
        }

        public ObservableCollection<TableColumn> GetData()
        {
            return Columns;
        }
    }
}

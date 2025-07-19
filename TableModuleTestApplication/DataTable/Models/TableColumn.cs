using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableModuleTestApplication.DataTable.Models
{
    public class TableColumn
    {
        public string Header { get; set; }
        public ColumnType Type { get; set; }
        public ObservableCollection<object> Values { get; set; } = new();
    }
    public enum ColumnType { 
        TextBox,
        CheckBox,
        ComboBox,
    }
}

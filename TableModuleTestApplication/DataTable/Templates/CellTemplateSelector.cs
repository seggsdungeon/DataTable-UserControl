using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using TableModuleTestApplication.DataTable.Models;

namespace TableModuleTestApplication.DataTable.Templates
{
    class CellTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TextBoxTemplate { get; set; }

        public ColumnType ColumnType { get; set; }
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            return ColumnType switch
            {
                ColumnType.TextBox => TextBoxTemplate,
                _ => TextBoxTemplate // default for now
            };
        }
    }
}

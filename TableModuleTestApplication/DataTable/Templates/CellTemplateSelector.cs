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
            if (item is TableColumn col)
            {

                switch (col.Type)
                {
                    case ColumnType.TextBox:
                        return TextBoxTemplate;
                    case ColumnType.CheckBox:
                        return null; // Return CheckBox template here
                    case ColumnType.ComboBox:
                        return null; // Return CheckBox template here
                    default: return TextBoxTemplate;
                }
            }
            else
            {
                return base.SelectTemplateCore(item, container);
            }
        }
    }
}

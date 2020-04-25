using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Extensions
{
   public static class CustomExtensions
    {
        public static void BindCombobox<T>(this ComboBox combobox, string displayMember, string valueMember, List<T> dataSource)
        {
            combobox.DataSource = dataSource;
            combobox.DisplayMember = displayMember;
            combobox.ValueMember = valueMember;
        }
    }
}

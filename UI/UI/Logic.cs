using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Logic
    {
        public static void LoadListColumns(List<string> data, System.Windows.Forms.ListView ll)
        {
            ll.Columns.Clear();
            
            foreach (var item in data)
            {
                var t = new System.Windows.Forms.ColumnHeader();
                t.Text = item;
                ll.Columns.Add(t);
            }
        }
        public static void LoadListColumns(List<string> data,System.Windows.Forms.ComboBox ll)
        {
            ll.Items.Clear();

            foreach (var item in data)
            {
                ll.Items.Add(item);
            }
            ll.SelectedIndex = 0;
        }
        public static void LoadListData(List<List<object>> data, System.Windows.Forms.ListView ll)
        {
            
            ll.Items.Clear();
            foreach (var item in data)
            {
                var t = new System.Windows.Forms.ListViewItem();
                t.Text = item[0].ToString();
                for (int i = 1; i < item.Count; i++)
                {
                    t.SubItems.Add(item[i].ToString());
                }
                ll.Items.Add(t);
            }
        }
        public static void LoadListData(List<List<object>> data, System.Windows.Forms.ListBox ll)
        {
            ll.Items.Clear();
            foreach (var item in data)
            {
                ll.Items.Add(item[1]);
            }
        }
    }
}

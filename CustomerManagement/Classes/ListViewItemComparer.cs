using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace CustomerManagement.Classes
{
    public class ListViewItemComparer : IComparer
    {
        private SortOrder Order;
        public int Column { get; }

        public ListViewItemComparer()
        {
            Column = 0;
            Order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            Column = column;
            Order = order;
        }

        public int Compare(object x, object y)
        {
            int result = string.Compare(((ListViewItem)x).SubItems[Column].Text, ((ListViewItem)y).SubItems[Column].Text);

            return Order == SortOrder.Ascending ? result : -result;
        }
    }
}

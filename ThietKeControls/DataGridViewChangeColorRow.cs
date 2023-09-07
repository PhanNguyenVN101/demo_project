using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class DataGridViewChangeColorRow : DataGridView
    {
        public DataGridViewChangeColorRow()
        {
            this.CellFormatting += DataGridViewChangeColorRow_CellFormatting;
        }

        private void DataGridViewChangeColorRow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in this.Rows)
            {
                if (row.Index % 2 == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}

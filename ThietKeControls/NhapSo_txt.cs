using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class NhapSo_txt:TextBox
    {
        public NhapSo_txt()
        {
            this.KeyPress +=NhapSo_txt_KeyPress;
        }

        private void NhapSo_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

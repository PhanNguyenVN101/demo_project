using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class UserTextBox:TextBox
    {
        ErrorProvider dl = new ErrorProvider();
        public UserTextBox()
        {
            this.KeyPress+=UserTextBox_KeyPress;
        }

        private void UserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                dl.SetError(this, "Error");
            else
                dl.SetError(this, "");
        }
    }
}

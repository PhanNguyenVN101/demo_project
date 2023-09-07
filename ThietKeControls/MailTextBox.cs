using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class MailTextBox:TextBox
    {
        ErrorProvider dl = new ErrorProvider();
        
        public MailTextBox()
        {
            this.TextChanged += MailTextBox_TextChanged;
        }

        private void MailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!this.Text.Contains('@') || !this.Text.Contains(".com"))
            {
                dl.SetError(this, "Error email");
            }
            else
                dl.Clear();
        }

        

        


        
    }
}

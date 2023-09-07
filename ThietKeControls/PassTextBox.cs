using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class PassTextBox:TextBox
    {
        ErrorProvider er = new ErrorProvider();
        public PassTextBox()
        {
            this.TextChanged+=PassTextBox_TextChanged;
        }

        private void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            char[] c = this.Text.ToCharArray();
            bool flag = true;
            foreach(char c1 in c) 
            {
                if(!char.IsLetterOrDigit(c1))
                    flag = false;
            }
            if(flag == true && this.Text.Length < 6)
            {
                er.SetError(this, "Error passText");
            }
            else
                er.Clear();

        }
    }
}

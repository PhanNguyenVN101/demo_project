using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class HoverButton:Button
    {
        public HoverButton() 
        {
            this.MouseHover += HoverButton_MouseHover;
            this.MouseLeave += HoverButton_MouseLeave;
        }

        private void HoverButton_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = SystemColors.Control;
        }

        private void HoverButton_MouseHover(object sender, EventArgs e)
        {
           Button button = sender as Button;
            button.BackColor = Color.Red;
        }
    }
}

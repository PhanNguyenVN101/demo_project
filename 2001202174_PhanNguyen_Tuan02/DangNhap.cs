using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001202174_PhanNguyen_Tuan02
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TK.Text.Trim();
            BTM01 bt = new BTM01();
            bt.TK1 = username;
            bt.Show();

        }
    }
}

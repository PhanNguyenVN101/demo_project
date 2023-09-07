using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ThuVien;

namespace _2001202174_PhanNguyen_Tuan02
{
    public partial class BTM01 : Form
    {
        string TK;

        public string TK1
        {
          get { return TK; }
          set { TK = value; }
        }
            
        public BTM01()
        {
            
            InitializeComponent();
        }

        private void BTM01_Load(object sender, EventArgs e)
        {
            statusBar1.Text = "Chào mừng người dùng: "+TK;
            LoadData();
            
        }
        SqlClass sqlClass = new SqlClass();
        public void LoadData()
        {
            string SeverNameDB = "DESKTOP-MEV5PNJ\\SQLEXPRESS";
            string DBName = "DEMO_TUAN02";
            string ConnectStr = "Data Source=" + SeverNameDB + ";Initial Catalog=" + DBName + ";Integrated Security=True";
            sqlClass.CreateConnection(ConnectStr);
            if(sqlClass.TestConnection)
            {
                string sql = "select * from SinhVien";
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlClass.getDataReader(sql));
                dataGridViewChangeColorRow1.DataSource = dataTable;
                sqlClass.Con.Close();

            }

        }
    }
}

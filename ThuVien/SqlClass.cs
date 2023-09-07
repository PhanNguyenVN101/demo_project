using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class SqlClass
    {
        SqlConnection con;
        public SqlConnection Con
        { 
            get { return con; }   
            set { con = value; } 
        }
        public SqlClass()
        {

        }
        public void CreateConnection(string pConnectionString)
        {
            con = new SqlConnection(pConnectionString);
        }
        public bool TestConnection
        {
            get{
                if(con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                return true;
            }

        }
        public bool Insert(string pQuery)
        {
            SqlCommand cmd = new SqlCommand(pQuery, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                return true;
            return false;

        }
        public bool Update(string pQuery)
        {
            SqlCommand cmd = new SqlCommand(pQuery, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                return true;
            return false;
        }
        public bool Delete(string pQuery)
        {
            SqlCommand cmd = new SqlCommand(pQuery, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                return true;
            return false;
        }
        public SqlDataReader getDataReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }

    }
}

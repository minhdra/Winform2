using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Winform2.DAL
{
    class DataHelper
    {
        string strcon = @"Data Source=DESKTOP-T7M1CD1\SQLEXPRESS;Initial Catalog=Database_Winform;Integrated Security=True";
        SqlConnection con;
        public DataHelper(string strcon)
        {
            this.strcon = strcon;
            con = new SqlConnection(strcon);
        }

        public DataHelper()
        {
            con = new SqlConnection(strcon);
        }

        public string Open()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
}

        public void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlDataReader ExcuteReader(string sqlSelect)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public void ExcuteNonQuery(string sql)
        {
            Open();

            SqlCommand cm = new SqlCommand(sql, con);
            cm.ExecuteNonQuery();
            Close();
        }
    }
}

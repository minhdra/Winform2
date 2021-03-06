using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataHelper
    {
        public string strcon = @"Data Source=DESKTOP-T7M1CD1\SQLEXPRESS;Initial Catalog=Database_Winform;Integrated Security=True";
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
                if (con.State == ConnectionState.Closed)
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
            if (con.State == ConnectionState.Open)
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
        /// <summary>
        /// This method to get database by SqlDataAdapter
        /// </summary>
        /// <param name="sql">select sql statement</param>
        /// <returns>Data table contain records</returns>
        public DataTable fillDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, strcon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void insertRow(DataTable dt, params object[] values)
        {
            DataRow dr = dt.NewRow();
            for (int i = 0; i < values.Length; i++)
            {
                dr[i] = values[i];
            }
            dt.Rows.Add(dr);
        }

        public void insertRow2(DataTable dt, params object[] Fields_values)
        {
            DataRow dr = dt.NewRow();
            for (int i = 0; i < Fields_values.Length; i += 2)
            {
                dr[Fields_values[i].ToString()] = Fields_values[i + 1].ToString();
            }
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserDAO
    {
        public static DataHelper dh;
        public UserDAO(string strcon)
        {
            dh = new DataHelper(strcon);
        }

        public Users GetUsers(string ma, string pass)
        {
            SqlDataReader dr = dh.ExcuteReader("" +
                "select * " +
                "from Users " +
                "where MaNV = '" + ma + "' " +
                "and Password = '" + pass + "'");

            if (dr.Read() == true)
            {
                Users us = new Users();
                us.MaNV = dr[0].ToString();
                us.Password = dr[1].ToString();
                us.Role = dr[2].ToString();
                if (dr[3].ToString() == "0")
                    us.Active = false;
                else
                    us.Active = true;

                dh.Close();
                return us;
            }
            else
                return null;
        }
    }
}

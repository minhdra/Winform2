using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform2.Entities;
using Winform2.DAL;

namespace Winform2.BUS
{
    class LoginBUS
    {
        UserDAO usDAO = new UserDAO(@"Data Source=DESKTOP-T7M1CD1\SQLEXPRESS;Initial Catalog=Database_Winform;Integrated Security=True");
        public Users checkUser(string maNV, string pass)
        {
            return usDAO.GetUsers(maNV, pass);
        }
    }
}

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
        UserDAO usDAO = new UserDAO(Program.strcon);
        public Users checkUser(string maNV, string pass)
        {
            return usDAO.GetUsers(maNV, pass);
        }
    }
}

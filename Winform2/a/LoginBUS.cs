using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUSS
{
    public class LoginBUS
    {
        UserDAO usDAO; //= new UserDAO(Program.strcon);
        public Users checkUser(string maNV, string pass)
        {
            return usDAO.GetUsers(maNV, pass);
        }
    }
}

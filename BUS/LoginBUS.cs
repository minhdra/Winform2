using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoginBUS
    {
        DataHelper dh = new DataHelper();
        UserDAO usDAO;
        public Users checkUser(string maNV, string pass)
        {
            usDAO = new UserDAO(dh.strcon);
            return usDAO.GetUsers(maNV, pass);
        }
    }
}

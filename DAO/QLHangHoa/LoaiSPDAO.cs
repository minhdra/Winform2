using DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiSPDAO
    {
        DataHelper dth;
        public LoaiSPDAO(string strcon)
        {
            dth = new DataHelper(strcon);
        }

        public List<LoaiSP> getAllLoai()
        {
            SqlDataReader dr = dth.ExcuteReader("select * from LoaiSP");
            List<LoaiSP> list = new List<LoaiSP>();
            while (dr.Read())
            {
                LoaiSP lsp = new LoaiSP();
                lsp.MaLoai = dr["MaLoai"].ToString();
                lsp.TenLoai = dr["TenLoai"].ToString();
                list.Add(lsp);
            }
            return list;
        }
    }
}

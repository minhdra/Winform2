using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform2.Entities;
using System.Data.SqlClient;

namespace Winform2.DAL
{
    class LoaiSPDAO
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

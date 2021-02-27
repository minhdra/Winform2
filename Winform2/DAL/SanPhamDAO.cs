using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Winform2.Entities;

namespace Winform2.DAL
{
    class SanPhamDAO
    {
        DataHelper dth;
        public SanPhamDAO(string strcon)
        {
            dth = new DataHelper(strcon);
        }

        public List<SanPham> getSanPhamMaLoai(string maL)
        {
            SqlDataReader dr = dth.ExcuteReader("select * from SanPham where MaLoai = '" + maL + "'");
            List<SanPham> list = new List<SanPham>();
            while (dr.Read())
            {
                SanPham sp = new SanPham();
                sp.MaSP = dr["MaSP"].ToString();
                sp.TenSP = dr["TenSP"].ToString();
                sp.MaLoai = dr["MaLoai"].ToString();
                sp.DonVi = dr["DonVi"].ToString();
                sp.MoTa = dr["MoTa"].ToString();
                sp.AnhTo = dr["AnhTo"].ToString();
                sp.AnhNho = dr["AnhNho"].ToString();
                list.Add(sp);
            }
            return list;
        }

        public List<SanPham> getAllSanPham()
        {
            SqlDataReader dr = dth.ExcuteReader("select * from SanPham");
            List<SanPham> list = new List<SanPham>();
            while (dr.Read())
            {
                SanPham sp = new SanPham();
                sp.MaSP = dr["MaSP"].ToString();
                sp.TenSP = dr["TenSP"].ToString();
                sp.MaLoai = dr["MaLoai"].ToString();
                sp.DonVi = dr["DonVi"].ToString();
                sp.MoTa = dr["MoTa"].ToString();
                sp.AnhTo = dr["AnhTo"].ToString();
                sp.AnhNho = dr["AnhNho"].ToString();
                list.Add(sp);
            }
            return list;
        }

        public void ThemSP(SanPham sp)
        {
            dth.ExcuteNonQuery("" +
                "insert into SanPham (MaSP, TenSP, MaLoai, DonVi, MoTa)" +
                "values (N'" + sp.MaSP + "',N'" + sp.TenSP + "',N'" + sp.MaLoai + "',N'" + sp.DonVi + "',N'" + sp.MoTa +"')");
        }

        public void SuaSP(SanPham sp)
        {
            dth.ExcuteNonQuery("" +
                "update SanPham " +
                "set TenSP = '" + sp.TenSP + "', MaLoai = '" + sp.MaLoai + "', DonVi = '" + sp.DonVi + "', MoTa = '" + sp.MoTa + "' " +
                "where MaSP = '" + sp.MaSP+"'");
        }

        public void XoaSP(string maSP)
        {
            dth.ExcuteNonQuery("" +
                "delete from SanPham " +
                "where MaSP = '" + maSP + "'");
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        DataHelper dth;
        DataTable dt;
        public SanPhamDAO(string strcon)
        {
            dth = new DataHelper(strcon);
        }

        public List<SanPham> getSanPhamMaLoai(string maL)
        {
            dt = dth.fillDataTable("select * from SanPham where MaLoai = '" + maL + "'");
            List<SanPham> list = new List<SanPham>();
            foreach (DataRow dr in dt.Rows)
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

        public DataTable getAllSanPham_DT()
        {
            dt = dth.fillDataTable("select * from SanPham");
            return dt;
        }

        public void ThemSP_P(SanPham sp)
        {
            dth.insertRow(dt, sp.MaSP, sp.TenSP, sp.MaLoai, sp.DonVi, sp.MoTa);
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
            dr.Close();
            dth.Close();
            return list;
        }

        public void ThemSP(SanPham sp)
        {
            dth.ExcuteNonQuery("" +
                "insert into SanPham (MaSP, TenSP, MaLoai, DonVi, MoTa)" +
                "values (N'" + sp.MaSP + "',N'" + sp.TenSP + "',N'" + sp.MaLoai + "',N'" + sp.DonVi + "',N'" + sp.MoTa + "')");
        }

        public void SuaSP(SanPham sp)
        {
            dth.ExcuteNonQuery("" +
                "update SanPham " +
                "set TenSP = '" + sp.TenSP + "', MaLoai = '" + sp.MaLoai + "', DonVi = '" + sp.DonVi + "', MoTa = '" + sp.MoTa + "' " +
                "where MaSP = '" + sp.MaSP + "'");
        }

        public void XoaSP(string maSP)
        {
            dth.ExcuteNonQuery("" +
                "delete from SanPham " +
                "where MaSP = '" + maSP + "'");
        }
    }
}

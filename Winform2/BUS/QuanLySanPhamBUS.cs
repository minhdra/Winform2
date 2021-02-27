using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winform2.Entities;
using Winform2.DAL;

namespace Winform2.BUS
{
    class QuanLySanPhamBUS
    {
        SanPhamDAO spd;
        LoaiSPDAO ld;

        public QuanLySanPhamBUS(string strcon)
        {
            spd = new SanPhamDAO(strcon);
            ld = new LoaiSPDAO(strcon);
        }

        public List<SanPham> getSanPham()
        {
            return spd.getAllSanPham();
        }

        public List<LoaiSP> getLoai()
        {
            return ld.getAllLoai();
        }

        public List<SanPham> getSanPhamMa(string ma)
        {
            return spd.getSanPhamMaLoai(ma);
        }

        public void themSP(SanPham sp)
        {
            spd.ThemSP(sp);

        }

        public void SuaSP(SanPham sp)
        {
            spd.SuaSP(sp);
        }

        public void XoaSP(string maSP)
        {
            spd.XoaSP(maSP);
        }
    }
}

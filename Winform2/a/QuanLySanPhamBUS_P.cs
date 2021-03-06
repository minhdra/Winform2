using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUSS
{
    public class QuanLySanPhamBUS_P
    {
        SanPhamDAO spd;
        LoaiSPDAO ld;

        public QuanLySanPhamBUS_P(string strcon)
        {
            spd = new SanPhamDAO(strcon);
            ld = new LoaiSPDAO(strcon);
        }

        public List<SanPham> getSanPhamMaLoai(string maL)
        {
            return spd.getSanPhamMaLoai(maL);
        }

        public List<LoaiSP> getLoai()
        {
            return ld.getAllLoai();
        }

        public DataTable getAllSp_DT()
        {
            return spd.getAllSanPham_DT();
        }

        public void ThemSp(SanPham sp)
        {
            spd.ThemSP(sp);
        }
    }
}

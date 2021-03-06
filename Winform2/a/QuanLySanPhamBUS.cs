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
    public class QuanLySanPhamBUS
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

        public string setMaSP()
        {
            string maSP = "SP";
            Random ran = new Random();
            int i = ran.Next(0, 100);
            maSP += i;

            List<SanPham> lsp = spd.getAllSanPham();

            for (int x = 0; x < lsp.Count; x++)
            {
                if (maSP == lsp[x].MaSP)
                {
                    setMaSP();
                    break;
                }
            }
            return maSP;
        }

        public bool themSP(SanPham sp)
        {
            sp.TenSP = sp.TenSP.Trim();
            List<SanPham> lsp = spd.getAllSanPham();
            for (int x = 0; x < lsp.Count; x++)
            {
                if (sp.MaSP == lsp[x].MaSP)
                {
                    return false;
                }
            }
            spd.ThemSP(sp);
            return true;
        }

        public bool SuaSP(SanPham sp)
        {
            List<SanPham> lsp = spd.getAllSanPham();
            for (int x = 0; x < lsp.Count; x++)
            {
                if (sp.MaSP == lsp[x].MaSP)
                {
                    spd.SuaSP(sp);
                    return true;
                }
            }
            return false;
        }

        public void XoaSP(string maSP)
        {
            spd.XoaSP(maSP);
        }
    }
}

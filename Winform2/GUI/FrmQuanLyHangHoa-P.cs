using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Winform2.GUI
{
    public partial class FrmQuanLyHangHoa_P : Form
    {
        QuanLySanPhamBUS_P qlP;
        List<LoaiSP> ll;
        List<SanPham> list;

        public FrmQuanLyHangHoa_P()
        {
            InitializeComponent();
        }

        private void btnthemmoiP_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuanLyHangHoa_P_Load(object sender, EventArgs e)
        {
            qlP = new QuanLySanPhamBUS_P(Program.strcon);
            ll = qlP.getLoai();
            cboLoaiP.DataSource = ll;
            cboLoaiP.DisplayMember = "TenLoai";
            cboLoaiP.ValueMember = "MaLoai";
        }

        private void cboLoaiP_SelectedIndexChanged(object sender, EventArgs e)
        {
            list = qlP.getSanPhamMaLoai(cboLoaiP.SelectedValue.ToString());
            dgvQlspP.DataSource = list;
        }

        private void btnthemspP_Click(object sender, EventArgs e)
        {
            if (cboLoaiP.Text != "" || txtMaSPP.Text != ""
                || txtTenP.Text != "" || txtMoTaP.Text != ""
                || cbodonviP.Text != "")
            {
                SanPham sp = new SanPham();

                sp.MaSP = txtMaSPP.Text;
                sp.TenSP = txtTenP.Text;
                sp.MaLoai = cboLoaiP.SelectedValue.ToString();
                sp.DonVi = cbodonviP.Text;
                sp.MoTa = txtMoTaP.Text;

                qlP.ThemSp(sp);
                list.Add(sp);
                //if (qlP.ThemSP(sp))
                //{
                //    MessageBox.Show("Thêm thành công!");
                //    lsp.Add(sp);
                //}
                //else
                //    MessageBox.Show("Mã : " + sp.MaSP + " đã tồn tại");
                dgvQlspP.DataSource = null;
                dgvQlspP.DataSource = list;

                // Chuyển đến dòng vừa thêm
                dgvQlspP.CurrentCell = dgvQlspP.Rows[dgvQlspP.Rows.Count - 1].Cells[0];
            }
        }
    }
}

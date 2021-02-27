using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform2.BUS;
using Winform2.Entities;

namespace Winform2.GUI
{
    public partial class FrmQuanLyHangHoa : Form
    {
        List<SanPham> lsp;
        List<LoaiSP> ll;
        QuanLySanPhamBUS qlbus;

        public FrmQuanLyHangHoa()
        {
            InitializeComponent();
        }

        private void lblMa_Click(object sender, EventArgs e)
        {

        }

        private void lblLoai_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuanLyHangHoa_Load(object sender, EventArgs e)
        {
            qlbus = new QuanLySanPhamBUS(Program.strcon);
            ll = qlbus.getLoai();
            cboLoai.DataSource = ll;
            cboLoai.DisplayMember = "MaLoai";
            cboLoai.ValueMember = "MaLoai";

            List<int> listdv = new List<int>();
            listdv.Add(1);
            listdv.Add(2);
            cbodonvi.DataSource = listdv;
        }

        private void cobLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnthemsp_Click(object sender, EventArgs e)
        {
            //if (cboLoai.SelectedItem != null || txtMa.Text != ""
            //    || txtTen.Text != "" || txtMoTa.Text != ""
            //    || cbodonvi.SelectedItem != null)
            //{
                SanPham sp = new SanPham();
                sp.MaSP = txtMa.Text;
                sp.TenSP = txtTen.Text;
                sp.MaLoai = cboLoai.Text;
                sp.DonVi = cbodonvi.SelectedItem.ToString();
                sp.MoTa = txtMoTa.Text;
                qlbus.themSP(sp);
                MessageBox.Show("Thêm sản phẩm thành công");
            //}

        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtMoTa.Clear();
            txtMa.Focus();
        }
    }
}

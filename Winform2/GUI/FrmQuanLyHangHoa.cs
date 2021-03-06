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
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";

            lsp = qlbus.getSanPham();
            dataGridView1.DataSource = lsp;

            List<int> listdv = new List<int>();
            listdv.Add(1);
            listdv.Add(2);
            cbodonvi.DataSource = listdv;

            txtMa.Text = qlbus.setMaSP();
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
            if (cboLoai.Text != "" || txtMa.Text != ""
                || txtTen.Text != "" || txtMoTa.Text != ""
                || cbodonvi.Text != "")
            {
                SanPham sp = new SanPham();
                
                sp.MaSP = txtMa.Text;
                sp.TenSP = txtTen.Text;
                sp.MaLoai = cboLoai.SelectedValue.ToString();
                sp.DonVi = cbodonvi.SelectedItem.ToString();
                sp.MoTa = txtMoTa.Text;
                
                if (qlbus.themSP(sp))
                {
                    MessageBox.Show("Thêm thành công!");
                    lsp.Add(sp);
                }
                else
                    MessageBox.Show("Mã : " + sp.MaSP + " đã tồn tại");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lsp;

                // Chuyển đến dòng vừa thêm
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            }

        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtMoTa.Clear();
            txtMa.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtMa.Text;
            sp.TenSP = txtTen.Text;
            sp.MaLoai = cboLoai.SelectedValue.ToString();
            sp.DonVi = cbodonvi.SelectedItem.ToString();
            sp.MoTa = txtMoTa.Text;
            if (qlbus.SuaSP(sp))
            {
                MessageBox.Show("Sửa thành công!");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lsp;
            }
            else
                MessageBox.Show("Không tìm thấy mã : " + sp.MaSP);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMa.Text;
            qlbus.XoaSP(maSP);

            SanPham sp = lsp.Find(i => i.MaSP == maSP);
            lsp.Remove(sp);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lsp;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMoTa.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

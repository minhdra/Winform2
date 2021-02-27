
namespace Winform2.GUI
{
    partial class FrmQuanLyHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblDonvi = new System.Windows.Forms.Label();
            this.lblMota = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.btnthemsp = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.cbodonvi = new System.Windows.Forms.ComboBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(12, 9);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Padding = new System.Windows.Forms.Padding(5);
            this.lblLoai.Size = new System.Drawing.Size(123, 30);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại sản phẩm";
            this.lblLoai.Click += new System.EventHandler(this.lblLoai_Click);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(199, 9);
            this.lblMa.Name = "lblMa";
            this.lblMa.Padding = new System.Windows.Forms.Padding(5);
            this.lblMa.Size = new System.Drawing.Size(115, 30);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã sản phẩm";
            this.lblMa.Click += new System.EventHandler(this.lblMa_Click);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(203, 42);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(111, 20);
            this.txtMa.TabIndex = 0;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(374, 9);
            this.lblTen.Name = "lblTen";
            this.lblTen.Padding = new System.Windows.Forms.Padding(5);
            this.lblTen.Size = new System.Drawing.Size(120, 30);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên sản phẩm";
            this.lblTen.Click += new System.EventHandler(this.lblMa_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(378, 42);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(333, 20);
            this.txtTen.TabIndex = 1;
            // 
            // lblDonvi
            // 
            this.lblDonvi.AutoSize = true;
            this.lblDonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonvi.Location = new System.Drawing.Point(12, 87);
            this.lblDonvi.Name = "lblDonvi";
            this.lblDonvi.Padding = new System.Windows.Forms.Padding(5);
            this.lblDonvi.Size = new System.Drawing.Size(63, 30);
            this.lblDonvi.TabIndex = 0;
            this.lblDonvi.Text = "Đơn vị";
            this.lblDonvi.Click += new System.EventHandler(this.lblLoai_Click);
            // 
            // lblMota
            // 
            this.lblMota.AutoSize = true;
            this.lblMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMota.Location = new System.Drawing.Point(199, 87);
            this.lblMota.Name = "lblMota";
            this.lblMota.Padding = new System.Windows.Forms.Padding(5);
            this.lblMota.Size = new System.Drawing.Size(59, 30);
            this.lblMota.TabIndex = 0;
            this.lblMota.Text = "Mô tả";
            this.lblMota.Click += new System.EventHandler(this.lblLoai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 259);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(203, 120);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(508, 77);
            this.txtMoTa.TabIndex = 3;
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.Location = new System.Drawing.Point(16, 212);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(75, 23);
            this.btnthemmoi.TabIndex = 4;
            this.btnthemmoi.Text = "Thêm mới";
            this.btnthemmoi.UseVisualStyleBackColor = true;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // btnthemsp
            // 
            this.btnthemsp.Location = new System.Drawing.Point(124, 212);
            this.btnthemsp.Name = "btnthemsp";
            this.btnthemsp.Size = new System.Drawing.Size(75, 23);
            this.btnthemsp.TabIndex = 5;
            this.btnthemsp.Text = "Thêm SP";
            this.btnthemsp.UseVisualStyleBackColor = true;
            this.btnthemsp.Click += new System.EventHandler(this.btnthemsp_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(250, 212);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa SP";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(369, 212);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa SP";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(491, 212);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // cbodonvi
            // 
            this.cbodonvi.FormattingEnabled = true;
            this.cbodonvi.Location = new System.Drawing.Point(16, 120);
            this.cbodonvi.Name = "cbodonvi";
            this.cbodonvi.Size = new System.Drawing.Size(121, 21);
            this.cbodonvi.TabIndex = 2;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(16, 42);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(121, 21);
            this.cboLoai.TabIndex = 4;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cobLoai_SelectedIndexChanged);
            // 
            // FrmQuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.cbodonvi);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthemsp);
            this.Controls.Add(this.btnthemmoi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblMota);
            this.Controls.Add(this.lblDonvi);
            this.Controls.Add(this.lblLoai);
            this.Name = "FrmQuanLyHangHoa";
            this.Text = "FrmQuanLyHangHoa";
            this.Load += new System.EventHandler(this.FrmQuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblDonvi;
        private System.Windows.Forms.Label lblMota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnthemmoi;
        private System.Windows.Forms.Button btnthemsp;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ComboBox cbodonvi;
        private System.Windows.Forms.ComboBox cboLoai;
    }
}
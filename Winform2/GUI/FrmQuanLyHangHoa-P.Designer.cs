
namespace Winform2.GUI
{
    partial class FrmQuanLyHangHoa_P
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
            this.cboLoaiP = new System.Windows.Forms.ComboBox();
            this.cbodonviP = new System.Windows.Forms.ComboBox();
            this.btnexitP = new System.Windows.Forms.Button();
            this.btnxoaP = new System.Windows.Forms.Button();
            this.btnsuaP = new System.Windows.Forms.Button();
            this.btnthemspP = new System.Windows.Forms.Button();
            this.btnthemmoiP = new System.Windows.Forms.Button();
            this.dgvQlspP = new System.Windows.Forms.DataGridView();
            this.txtTenP = new System.Windows.Forms.TextBox();
            this.txtMoTaP = new System.Windows.Forms.TextBox();
            this.txtMaSPP = new System.Windows.Forms.TextBox();
            this.lblTenP = new System.Windows.Forms.Label();
            this.lblMaSPP = new System.Windows.Forms.Label();
            this.lblMotaP = new System.Windows.Forms.Label();
            this.lblDonviP = new System.Windows.Forms.Label();
            this.lblLoaiP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlspP)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLoaiP
            // 
            this.cboLoaiP.FormattingEnabled = true;
            this.cboLoaiP.Location = new System.Drawing.Point(16, 42);
            this.cboLoaiP.Name = "cboLoaiP";
            this.cboLoaiP.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiP.TabIndex = 19;
            this.cboLoaiP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiP_SelectedIndexChanged);
            // 
            // cbodonviP
            // 
            this.cbodonviP.FormattingEnabled = true;
            this.cbodonviP.Location = new System.Drawing.Point(16, 120);
            this.cbodonviP.Name = "cbodonviP";
            this.cbodonviP.Size = new System.Drawing.Size(121, 21);
            this.cbodonviP.TabIndex = 2;
            // 
            // btnexitP
            // 
            this.btnexitP.Location = new System.Drawing.Point(491, 212);
            this.btnexitP.Name = "btnexitP";
            this.btnexitP.Size = new System.Drawing.Size(75, 23);
            this.btnexitP.TabIndex = 8;
            this.btnexitP.Text = "Thoát";
            this.btnexitP.UseVisualStyleBackColor = true;
            // 
            // btnxoaP
            // 
            this.btnxoaP.Location = new System.Drawing.Point(369, 212);
            this.btnxoaP.Name = "btnxoaP";
            this.btnxoaP.Size = new System.Drawing.Size(75, 23);
            this.btnxoaP.TabIndex = 7;
            this.btnxoaP.Text = "Xóa SP";
            this.btnxoaP.UseVisualStyleBackColor = true;
            // 
            // btnsuaP
            // 
            this.btnsuaP.Location = new System.Drawing.Point(250, 212);
            this.btnsuaP.Name = "btnsuaP";
            this.btnsuaP.Size = new System.Drawing.Size(75, 23);
            this.btnsuaP.TabIndex = 6;
            this.btnsuaP.Text = "Sửa SP";
            this.btnsuaP.UseVisualStyleBackColor = true;
            // 
            // btnthemspP
            // 
            this.btnthemspP.Location = new System.Drawing.Point(124, 212);
            this.btnthemspP.Name = "btnthemspP";
            this.btnthemspP.Size = new System.Drawing.Size(75, 23);
            this.btnthemspP.TabIndex = 5;
            this.btnthemspP.Text = "Thêm SP";
            this.btnthemspP.UseVisualStyleBackColor = true;
            this.btnthemspP.Click += new System.EventHandler(this.btnthemspP_Click);
            // 
            // btnthemmoiP
            // 
            this.btnthemmoiP.Location = new System.Drawing.Point(16, 212);
            this.btnthemmoiP.Name = "btnthemmoiP";
            this.btnthemmoiP.Size = new System.Drawing.Size(75, 23);
            this.btnthemmoiP.TabIndex = 4;
            this.btnthemmoiP.Text = "Thêm mới";
            this.btnthemmoiP.UseVisualStyleBackColor = true;
            this.btnthemmoiP.Click += new System.EventHandler(this.btnthemmoiP_Click);
            // 
            // dgvQlspP
            // 
            this.dgvQlspP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQlspP.Location = new System.Drawing.Point(12, 241);
            this.dgvQlspP.Name = "dgvQlspP";
            this.dgvQlspP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQlspP.Size = new System.Drawing.Size(710, 259);
            this.dgvQlspP.TabIndex = 17;
            // 
            // txtTenP
            // 
            this.txtTenP.Location = new System.Drawing.Point(378, 42);
            this.txtTenP.Name = "txtTenP";
            this.txtTenP.Size = new System.Drawing.Size(333, 20);
            this.txtTenP.TabIndex = 1;
            // 
            // txtMoTaP
            // 
            this.txtMoTaP.Location = new System.Drawing.Point(203, 120);
            this.txtMoTaP.Multiline = true;
            this.txtMoTaP.Name = "txtMoTaP";
            this.txtMoTaP.Size = new System.Drawing.Size(508, 77);
            this.txtMoTaP.TabIndex = 3;
            // 
            // txtMaSPP
            // 
            this.txtMaSPP.Location = new System.Drawing.Point(203, 42);
            this.txtMaSPP.Name = "txtMaSPP";
            this.txtMaSPP.Size = new System.Drawing.Size(111, 20);
            this.txtMaSPP.TabIndex = 0;
            // 
            // lblTenP
            // 
            this.lblTenP.AutoSize = true;
            this.lblTenP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenP.Location = new System.Drawing.Point(374, 9);
            this.lblTenP.Name = "lblTenP";
            this.lblTenP.Padding = new System.Windows.Forms.Padding(5);
            this.lblTenP.Size = new System.Drawing.Size(120, 30);
            this.lblTenP.TabIndex = 10;
            this.lblTenP.Text = "Tên sản phẩm";
            // 
            // lblMaSPP
            // 
            this.lblMaSPP.AutoSize = true;
            this.lblMaSPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSPP.Location = new System.Drawing.Point(199, 9);
            this.lblMaSPP.Name = "lblMaSPP";
            this.lblMaSPP.Padding = new System.Windows.Forms.Padding(5);
            this.lblMaSPP.Size = new System.Drawing.Size(115, 30);
            this.lblMaSPP.TabIndex = 11;
            this.lblMaSPP.Text = "Mã sản phẩm";
            // 
            // lblMotaP
            // 
            this.lblMotaP.AutoSize = true;
            this.lblMotaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotaP.Location = new System.Drawing.Point(199, 87);
            this.lblMotaP.Name = "lblMotaP";
            this.lblMotaP.Padding = new System.Windows.Forms.Padding(5);
            this.lblMotaP.Size = new System.Drawing.Size(59, 30);
            this.lblMotaP.TabIndex = 12;
            this.lblMotaP.Text = "Mô tả";
            // 
            // lblDonviP
            // 
            this.lblDonviP.AutoSize = true;
            this.lblDonviP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonviP.Location = new System.Drawing.Point(12, 87);
            this.lblDonviP.Name = "lblDonviP";
            this.lblDonviP.Padding = new System.Windows.Forms.Padding(5);
            this.lblDonviP.Size = new System.Drawing.Size(63, 30);
            this.lblDonviP.TabIndex = 13;
            this.lblDonviP.Text = "Đơn vị";
            // 
            // lblLoaiP
            // 
            this.lblLoaiP.AutoSize = true;
            this.lblLoaiP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiP.Location = new System.Drawing.Point(12, 9);
            this.lblLoaiP.Name = "lblLoaiP";
            this.lblLoaiP.Padding = new System.Windows.Forms.Padding(5);
            this.lblLoaiP.Size = new System.Drawing.Size(123, 30);
            this.lblLoaiP.TabIndex = 14;
            this.lblLoaiP.Text = "Loại sản phẩm";
            // 
            // FrmQuanLyHangHoa_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 507);
            this.Controls.Add(this.cboLoaiP);
            this.Controls.Add(this.cbodonviP);
            this.Controls.Add(this.btnexitP);
            this.Controls.Add(this.btnxoaP);
            this.Controls.Add(this.btnsuaP);
            this.Controls.Add(this.btnthemspP);
            this.Controls.Add(this.btnthemmoiP);
            this.Controls.Add(this.dgvQlspP);
            this.Controls.Add(this.txtTenP);
            this.Controls.Add(this.txtMoTaP);
            this.Controls.Add(this.txtMaSPP);
            this.Controls.Add(this.lblTenP);
            this.Controls.Add(this.lblMaSPP);
            this.Controls.Add(this.lblMotaP);
            this.Controls.Add(this.lblDonviP);
            this.Controls.Add(this.lblLoaiP);
            this.Name = "FrmQuanLyHangHoa_P";
            this.Text = "FrmQuanLyHangHoa_P";
            this.Load += new System.EventHandler(this.FrmQuanLyHangHoa_P_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlspP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLoaiP;
        private System.Windows.Forms.ComboBox cbodonviP;
        private System.Windows.Forms.Button btnexitP;
        private System.Windows.Forms.Button btnxoaP;
        private System.Windows.Forms.Button btnsuaP;
        private System.Windows.Forms.Button btnthemspP;
        private System.Windows.Forms.Button btnthemmoiP;
        private System.Windows.Forms.DataGridView dgvQlspP;
        private System.Windows.Forms.TextBox txtTenP;
        private System.Windows.Forms.TextBox txtMoTaP;
        private System.Windows.Forms.TextBox txtMaSPP;
        private System.Windows.Forms.Label lblTenP;
        private System.Windows.Forms.Label lblMaSPP;
        private System.Windows.Forms.Label lblMotaP;
        private System.Windows.Forms.Label lblDonviP;
        private System.Windows.Forms.Label lblLoaiP;
    }
}
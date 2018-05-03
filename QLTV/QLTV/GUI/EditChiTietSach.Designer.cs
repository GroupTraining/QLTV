namespace QLTV.GUI
{
    partial class EditChiTietSach
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
            this.lbMaSach = new System.Windows.Forms.Label();
            this.TenSach = new System.Windows.Forms.Label();
            this.lbTacGia = new System.Windows.Forms.Label();
            this.TheLoai = new System.Windows.Forms.Label();
            this.lbNhaXB = new System.Windows.Forms.Label();
            this.lbNgonNgu = new System.Windows.Forms.Label();
            this.lbLinhVuc = new System.Windows.Forms.Label();
            this.lbNamXB = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.txtNhaXB = new System.Windows.Forms.TextBox();
            this.txtNgonNgu = new System.Windows.Forms.TextBox();
            this.txtLinhVuc = new System.Windows.Forms.TextBox();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvChiTietSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaSach
            // 
            this.lbMaSach.AutoSize = true;
            this.lbMaSach.Location = new System.Drawing.Point(47, 43);
            this.lbMaSach.Name = "lbMaSach";
            this.lbMaSach.Size = new System.Drawing.Size(55, 13);
            this.lbMaSach.TabIndex = 0;
            this.lbMaSach.Text = "MÃ SÁCH";
            // 
            // TenSach
            // 
            this.TenSach.AutoSize = true;
            this.TenSach.Location = new System.Drawing.Point(47, 126);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(61, 13);
            this.TenSach.TabIndex = 1;
            this.TenSach.Text = "TÊN SÁCH";
            this.TenSach.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbTacGia
            // 
            this.lbTacGia.AutoSize = true;
            this.lbTacGia.Location = new System.Drawing.Point(47, 189);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(49, 13);
            this.lbTacGia.TabIndex = 2;
            this.lbTacGia.Text = "TÁC GIẢ";
            // 
            // TheLoai
            // 
            this.TheLoai.AutoSize = true;
            this.TheLoai.Location = new System.Drawing.Point(328, 43);
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.Size = new System.Drawing.Size(56, 13);
            this.TheLoai.TabIndex = 3;
            this.TheLoai.Text = "THỂ LOẠI";
            // 
            // lbNhaXB
            // 
            this.lbNhaXB.AutoSize = true;
            this.lbNhaXB.Location = new System.Drawing.Point(322, 126);
            this.lbNhaXB.Name = "lbNhaXB";
            this.lbNhaXB.Size = new System.Drawing.Size(87, 13);
            this.lbNhaXB.TabIndex = 4;
            this.lbNhaXB.Text = "NHÀ XUẤT BẢN";
            // 
            // lbNgonNgu
            // 
            this.lbNgonNgu.AutoSize = true;
            this.lbNgonNgu.Location = new System.Drawing.Point(328, 189);
            this.lbNgonNgu.Name = "lbNgonNgu";
            this.lbNgonNgu.Size = new System.Drawing.Size(66, 13);
            this.lbNgonNgu.TabIndex = 5;
            this.lbNgonNgu.Text = "NGÔN NGỮ";
            this.lbNgonNgu.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbLinhVuc
            // 
            this.lbLinhVuc.AutoSize = true;
            this.lbLinhVuc.Location = new System.Drawing.Point(643, 50);
            this.lbLinhVuc.Name = "lbLinhVuc";
            this.lbLinhVuc.Size = new System.Drawing.Size(59, 13);
            this.lbLinhVuc.TabIndex = 6;
            this.lbLinhVuc.Text = "LĨNH VỰC";
            // 
            // lbNamXB
            // 
            this.lbNamXB.AutoSize = true;
            this.lbNamXB.Location = new System.Drawing.Point(631, 126);
            this.lbNamXB.Name = "lbNamXB";
            this.lbNamXB.Size = new System.Drawing.Size(88, 13);
            this.lbNamXB.TabIndex = 7;
            this.lbNamXB.Text = "NĂM XUẤT BẢN";
            this.lbNamXB.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(121, 40);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(157, 20);
            this.txtMaSach.TabIndex = 9;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(121, 119);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(157, 20);
            this.txtTenSach.TabIndex = 10;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(121, 181);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(157, 20);
            this.txtTacGia.TabIndex = 11;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(415, 43);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(165, 20);
            this.txtTheLoai.TabIndex = 12;
            // 
            // txtNhaXB
            // 
            this.txtNhaXB.Location = new System.Drawing.Point(415, 119);
            this.txtNhaXB.Name = "txtNhaXB";
            this.txtNhaXB.Size = new System.Drawing.Size(165, 20);
            this.txtNhaXB.TabIndex = 13;
            // 
            // txtNgonNgu
            // 
            this.txtNgonNgu.Location = new System.Drawing.Point(415, 180);
            this.txtNgonNgu.Name = "txtNgonNgu";
            this.txtNgonNgu.Size = new System.Drawing.Size(165, 20);
            this.txtNgonNgu.TabIndex = 14;
            // 
            // txtLinhVuc
            // 
            this.txtLinhVuc.Location = new System.Drawing.Point(725, 43);
            this.txtLinhVuc.Name = "txtLinhVuc";
            this.txtLinhVuc.Size = new System.Drawing.Size(178, 20);
            this.txtLinhVuc.TabIndex = 15;
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(725, 119);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(178, 20);
            this.txtNamXB.TabIndex = 16;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(356, 259);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(532, 259);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvChiTietSach
            // 
            this.dgvChiTietSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietSach.Location = new System.Drawing.Point(121, 318);
            this.dgvChiTietSach.Name = "dgvChiTietSach";
            this.dgvChiTietSach.Size = new System.Drawing.Size(782, 175);
            this.dgvChiTietSach.TabIndex = 20;
            this.dgvChiTietSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietSach_CellClick);
            // 
            // EditChiTietSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 505);
            this.Controls.Add(this.dgvChiTietSach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtNamXB);
            this.Controls.Add(this.txtLinhVuc);
            this.Controls.Add(this.txtNgonNgu);
            this.Controls.Add(this.txtNhaXB);
            this.Controls.Add(this.txtTheLoai);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.lbNamXB);
            this.Controls.Add(this.lbLinhVuc);
            this.Controls.Add(this.lbNgonNgu);
            this.Controls.Add(this.lbNhaXB);
            this.Controls.Add(this.TheLoai);
            this.Controls.Add(this.lbTacGia);
            this.Controls.Add(this.TenSach);
            this.Controls.Add(this.lbMaSach);
            this.Name = "EditChiTietSach";
            this.Text = "EditChiTietSach";
            this.Load += new System.EventHandler(this.EditChiTietSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaSach;
        private System.Windows.Forms.Label TenSach;
        private System.Windows.Forms.Label lbTacGia;
        private System.Windows.Forms.Label TheLoai;
        private System.Windows.Forms.Label lbNhaXB;
        private System.Windows.Forms.Label lbNgonNgu;
        private System.Windows.Forms.Label lbLinhVuc;
        private System.Windows.Forms.Label lbNamXB;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.TextBox txtNhaXB;
        private System.Windows.Forms.TextBox txtNgonNgu;
        private System.Windows.Forms.TextBox txtLinhVuc;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvChiTietSach;
    }
}
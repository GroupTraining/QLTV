namespace QLTV.GUI
{
    partial class EditSinhVien
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
            this.lbMaSV = new System.Windows.Forms.Label();
            this.lbTenSV = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbSoDT = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.rdb_nam = new System.Windows.Forms.RadioButton();
            this.rdb_nu = new System.Windows.Forms.RadioButton();
            this.dtbBirtday = new System.Windows.Forms.DateTimePicker();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(18, 35);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(80, 13);
            this.lbMaSV.TabIndex = 0;
            this.lbMaSV.Text = "MÃ SINH VIÊN";
            // 
            // lbTenSV
            // 
            this.lbTenSV.AutoSize = true;
            this.lbTenSV.Location = new System.Drawing.Point(12, 87);
            this.lbTenSV.Name = "lbTenSV";
            this.lbTenSV.Size = new System.Drawing.Size(86, 13);
            this.lbTenSV.TabIndex = 1;
            this.lbTenSV.Text = "TÊN SINH VIÊN";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(22, 136);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(58, 13);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "GIỚI TÍNH";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(22, 199);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(66, 13);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "NGÀY SINH";
            this.lbNgaySinh.Click += new System.EventHandler(this.lbNgaySinh_Click);
            // 
            // lbSoDT
            // 
            this.lbSoDT.AutoSize = true;
            this.lbSoDT.Location = new System.Drawing.Point(12, 254);
            this.lbSoDT.Name = "lbSoDT";
            this.lbSoDT.Size = new System.Drawing.Size(87, 13);
            this.lbSoDT.TabIndex = 4;
            this.lbSoDT.Text = "SỐ ĐIỆN THOẠI";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(104, 28);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(129, 20);
            this.txtMaSV.TabIndex = 5;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(104, 80);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(129, 20);
            this.txtTenSV.TabIndex = 6;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Location = new System.Drawing.Point(104, 136);
            this.rdb_nam.Name = "rdb_nam";
            this.rdb_nam.Size = new System.Drawing.Size(49, 17);
            this.rdb_nam.TabIndex = 7;
            this.rdb_nam.TabStop = true;
            this.rdb_nam.Text = "NAM";
            this.rdb_nam.UseVisualStyleBackColor = true;
            // 
            // rdb_nu
            // 
            this.rdb_nu.AutoSize = true;
            this.rdb_nu.Location = new System.Drawing.Point(196, 136);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(41, 17);
            this.rdb_nu.TabIndex = 8;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "NỮ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // dtbBirtday
            // 
            this.dtbBirtday.Location = new System.Drawing.Point(104, 192);
            this.dtbBirtday.Name = "dtbBirtday";
            this.dtbBirtday.Size = new System.Drawing.Size(200, 20);
            this.dtbBirtday.TabIndex = 9;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(104, 247);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(129, 20);
            this.txtSoDT.TabIndex = 10;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(58, 336);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(196, 335);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(347, 28);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(534, 239);
            this.dgvSinhVien.TabIndex = 13;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // EditSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 414);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.dtbBirtday);
            this.Controls.Add(this.rdb_nu);
            this.Controls.Add(this.rdb_nam);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lbSoDT);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.lbTenSV);
            this.Controls.Add(this.lbMaSV);
            this.Name = "EditSinhVien";
            this.Text = "EditSinhVien";
            this.Load += new System.EventHandler(this.EditSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label lbTenSV;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbSoDT;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.RadioButton rdb_nam;
        private System.Windows.Forms.RadioButton rdb_nu;
        private System.Windows.Forms.DateTimePicker dtbBirtday;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvSinhVien;
    }
}
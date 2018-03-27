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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN SINH VIÊN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "GIỚI TÍNH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NGÀY SINH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SỐ ĐIỆN THOẠI";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(119, 27);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(136, 20);
            this.txtMaSV.TabIndex = 5;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(119, 77);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(136, 20);
            this.txtTenSV.TabIndex = 6;
            // 
            // rdb_nam
            // 
            this.rdb_nam.AutoSize = true;
            this.rdb_nam.Location = new System.Drawing.Point(119, 140);
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
            this.rdb_nu.Location = new System.Drawing.Point(222, 140);
            this.rdb_nu.Name = "rdb_nu";
            this.rdb_nu.Size = new System.Drawing.Size(41, 17);
            this.rdb_nu.TabIndex = 8;
            this.rdb_nu.TabStop = true;
            this.rdb_nu.Text = "NỮ";
            this.rdb_nu.UseVisualStyleBackColor = true;
            // 
            // dtbBirtday
            // 
            this.dtbBirtday.Location = new System.Drawing.Point(119, 187);
            this.dtbBirtday.Name = "dtbBirtday";
            this.dtbBirtday.Size = new System.Drawing.Size(200, 20);
            this.dtbBirtday.TabIndex = 9;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(119, 252);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(136, 20);
            this.txtSoDT.TabIndex = 10;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(30, 361);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(222, 361);
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
            this.dgvSinhVien.Location = new System.Drawing.Point(376, 27);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(526, 245);
            this.dgvSinhVien.TabIndex = 13;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // EditSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 461);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.dtbBirtday);
            this.Controls.Add(this.rdb_nu);
            this.Controls.Add(this.rdb_nam);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditSinhVien";
            this.Text = "EditSinhVien";
            this.Load += new System.EventHandler(this.EditSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
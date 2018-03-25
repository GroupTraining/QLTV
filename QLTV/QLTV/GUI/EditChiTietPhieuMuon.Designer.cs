namespace QLTV.GUI
{
    partial class EditChiTietPhieuMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txt_mapm = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_masach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_tienphat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.date_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.date_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.date_hanmuon = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(12, 232);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(673, 233);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellClick);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.date_hanmuon);
            this.groupPanel1.Controls.Add(this.date_ngaymuon);
            this.groupPanel1.Controls.Add(this.date_ngaytra);
            this.groupPanel1.Controls.Add(this.btn_del);
            this.groupPanel1.Controls.Add(this.btn_update);
            this.groupPanel1.Controls.Add(this.txt_masach);
            this.groupPanel1.Controls.Add(this.txt_tienphat);
            this.groupPanel1.Controls.Add(this.txt_mapm);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(51, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(581, 214);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "CHỈNH SỬA THÔNG TIN PHIẾU MƯỢN";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(30, 35);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã PM";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(30, 74);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mã Sách";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(30, 118);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(88, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Ngày Trả";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(287, 35);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(102, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Ngày Mượn";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(287, 118);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(102, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Tiền Phạt";
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(287, 74);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(102, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Hạn Mượn";
            // 
            // txt_mapm
            // 
            // 
            // 
            // 
            this.txt_mapm.Border.Class = "TextBoxBorder";
            this.txt_mapm.Location = new System.Drawing.Point(122, 37);
            this.txt_mapm.Name = "txt_mapm";
            this.txt_mapm.Size = new System.Drawing.Size(159, 26);
            this.txt_mapm.TabIndex = 1;
            // 
            // txt_masach
            // 
            // 
            // 
            // 
            this.txt_masach.Border.Class = "TextBoxBorder";
            this.txt_masach.Location = new System.Drawing.Point(122, 74);
            this.txt_masach.Name = "txt_masach";
            this.txt_masach.Size = new System.Drawing.Size(159, 26);
            this.txt_masach.TabIndex = 1;
            // 
            // txt_tienphat
            // 
            // 
            // 
            // 
            this.txt_tienphat.Border.Class = "TextBoxBorder";
            this.txt_tienphat.Location = new System.Drawing.Point(395, 118);
            this.txt_tienphat.Name = "txt_tienphat";
            this.txt_tienphat.Size = new System.Drawing.Size(164, 26);
            this.txt_tienphat.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_update.Location = new System.Drawing.Point(340, 150);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(105, 34);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_del
            // 
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_del.ForeColor = System.Drawing.Color.Red;
            this.btn_del.Location = new System.Drawing.Point(454, 150);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(105, 34);
            this.btn_del.TabIndex = 2;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // date_ngaytra
            // 
            this.date_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaytra.Location = new System.Drawing.Point(125, 118);
            this.date_ngaytra.Name = "date_ngaytra";
            this.date_ngaytra.Size = new System.Drawing.Size(156, 26);
            this.date_ngaytra.TabIndex = 3;
            // 
            // date_ngaymuon
            // 
            this.date_ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaymuon.Location = new System.Drawing.Point(395, 32);
            this.date_ngaymuon.Name = "date_ngaymuon";
            this.date_ngaymuon.Size = new System.Drawing.Size(156, 26);
            this.date_ngaymuon.TabIndex = 3;
            // 
            // date_hanmuon
            // 
            this.date_hanmuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_hanmuon.Location = new System.Drawing.Point(395, 74);
            this.date_hanmuon.Name = "date_hanmuon";
            this.date_hanmuon.Size = new System.Drawing.Size(156, 26);
            this.date_hanmuon.TabIndex = 3;
            // 
            // EditChiTietPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 467);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.groupPanel1);
            this.Name = "EditChiTietPhieuMuon";
            this.Text = "EditChiTietPhieuMuon";
            this.Load += new System.EventHandler(this.EditChiTietPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_update;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_masach;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tienphat;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_mapm;
        private System.Windows.Forms.DateTimePicker date_hanmuon;
        private System.Windows.Forms.DateTimePicker date_ngaymuon;
        private System.Windows.Forms.DateTimePicker date_ngaytra;
    }
}
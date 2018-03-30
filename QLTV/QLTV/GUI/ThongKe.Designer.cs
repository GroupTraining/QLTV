namespace QLTV.GUI
{
    partial class ThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.comboBoxTieuChi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnThongKe = new DevComponents.DotNetBar.ButtonX();
            this.comboBoxChiTiet = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboBoxDeMuc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(2, 121);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(654, 202);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // comboBoxTieuChi
            // 
            this.comboBoxTieuChi.DisplayMember = "Text";
            this.comboBoxTieuChi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTieuChi.FormattingEnabled = true;
            this.comboBoxTieuChi.ItemHeight = 14;
            this.comboBoxTieuChi.Location = new System.Drawing.Point(170, 22);
            this.comboBoxTieuChi.Name = "comboBoxTieuChi";
            this.comboBoxTieuChi.Size = new System.Drawing.Size(119, 20);
            this.comboBoxTieuChi.TabIndex = 1;
            this.comboBoxTieuChi.SelectedIndexChanged += new System.EventHandler(this.comboBoxTieuChi_SelectedIndexChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThongKe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThongKe.Location = new System.Drawing.Point(469, 72);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // comboBoxChiTiet
            // 
            this.comboBoxChiTiet.DisplayMember = "Text";
            this.comboBoxChiTiet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxChiTiet.FormattingEnabled = true;
            this.comboBoxChiTiet.ItemHeight = 14;
            this.comboBoxChiTiet.Location = new System.Drawing.Point(325, 22);
            this.comboBoxChiTiet.Name = "comboBoxChiTiet";
            this.comboBoxChiTiet.Size = new System.Drawing.Size(173, 20);
            this.comboBoxChiTiet.TabIndex = 7;
            // 
            // comboBoxDeMuc
            // 
            this.comboBoxDeMuc.DisplayMember = "Text";
            this.comboBoxDeMuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDeMuc.FormattingEnabled = true;
            this.comboBoxDeMuc.ItemHeight = 14;
            this.comboBoxDeMuc.Location = new System.Drawing.Point(25, 22);
            this.comboBoxDeMuc.Name = "comboBoxDeMuc";
            this.comboBoxDeMuc.Size = new System.Drawing.Size(121, 20);
            this.comboBoxDeMuc.TabIndex = 8;
            this.comboBoxDeMuc.SelectedIndexChanged += new System.EventHandler(this.comboBoxDeMuc_SelectedIndexChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(568, 72);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(76, 23);
            this.buttonX1.TabIndex = 9;
            this.buttonX1.Text = "Back";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 325);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.comboBoxDeMuc);
            this.Controls.Add(this.comboBoxChiTiet);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.comboBoxTieuChi);
            this.Controls.Add(this.dataGridViewX1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxTieuChi;
        private DevComponents.DotNetBar.ButtonX btnThongKe;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxChiTiet;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxDeMuc;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}
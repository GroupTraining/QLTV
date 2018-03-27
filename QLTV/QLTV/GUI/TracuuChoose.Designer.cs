namespace QLTV.GUI
{
    partial class TracuuChoose
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonBack = new DevComponents.DotNetBar.ButtonX();
            this.buttonsrsach = new DevComponents.DotNetBar.ButtonX();
            this.buttonsrngmuon = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.buttonBack);
            this.panelEx1.Controls.Add(this.buttonsrsach);
            this.panelEx1.Controls.Add(this.buttonsrngmuon);
            this.panelEx1.Location = new System.Drawing.Point(1, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(602, 341);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonBack.Location = new System.Drawing.Point(454, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(99, 34);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonsrsach
            // 
            this.buttonsrsach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonsrsach.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonsrsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonsrsach.Location = new System.Drawing.Point(88, 157);
            this.buttonsrsach.Name = "buttonsrsach";
            this.buttonsrsach.Size = new System.Drawing.Size(262, 50);
            this.buttonsrsach.TabIndex = 1;
            this.buttonsrsach.Text = "Tra cứu Sách";
            this.buttonsrsach.Click += new System.EventHandler(this.buttonsrsach_Click);
            // 
            // buttonsrngmuon
            // 
            this.buttonsrngmuon.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonsrngmuon.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonsrngmuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonsrngmuon.Location = new System.Drawing.Point(88, 75);
            this.buttonsrngmuon.Name = "buttonsrngmuon";
            this.buttonsrngmuon.Size = new System.Drawing.Size(263, 47);
            this.buttonsrngmuon.TabIndex = 0;
            this.buttonsrngmuon.Text = "Tra cứu Người Mượn";
            this.buttonsrngmuon.Click += new System.EventHandler(this.buttonsrngmuon_Click);
            // 
            // TracuuChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 338);
            this.Controls.Add(this.panelEx1);
            this.Name = "TracuuChoose";
            this.Text = "TracuuChoose";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX buttonBack;
        private DevComponents.DotNetBar.ButtonX buttonsrsach;
        private DevComponents.DotNetBar.ButtonX buttonsrngmuon;
    }
}
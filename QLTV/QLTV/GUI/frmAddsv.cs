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

namespace QLTV.GUI
{
    public partial class frmAddsv : Form
    {
        Bus db = new Bus();
        public frmAddsv()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int x = db.add_sinhvien(txtMasv.Text, txtTensv.Text, cbGt.Text, dtpNs.Text, txtSdt.Text, txtLop.Text);
            if (x == 1)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kiểm tra lại mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

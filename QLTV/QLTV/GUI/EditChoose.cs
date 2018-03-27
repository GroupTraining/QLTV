using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.GUI
{
    public partial class EditChoose : Form
    {
        public EditChoose()
        {
            InitializeComponent();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.Main home = new GUI.Main();
            home.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.EditNhanVien editnv = new GUI.EditNhanVien();
            editnv.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.EditChiTietPhieuMuon editpm = new GUI.EditChiTietPhieuMuon();
            editpm.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.EditChiTietSach editsach = new GUI.EditChiTietSach();
            editsach.Show();
        }
    }
}

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
    public partial class AddChoose : Form
    {
        public AddChoose()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmAddsv addsv = new GUI.frmAddsv();
            addsv.Show();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.AddNhanVien themnv = new GUI.AddNhanVien();
            themnv.Show();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.AddChiTietSach themsach = new GUI.AddChiTietSach();
            themsach.Show();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.Main home = new GUI.Main();
            home.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.frmAddpm addpm = new GUI.frmAddpm();
            addpm.Show();
        }
    }
}

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
    public partial class TracuuChoose : Form
    {
        public TracuuChoose()
        {
            InitializeComponent();
        }

        private void buttonsrsach_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.TimkiemSach tksach = new GUI.TimkiemSach();
            tksach.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.Main mainchinh = new GUI.Main();
            mainchinh.Show();

        }

        private void buttonsrngmuon_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.TimKiemNguoiMuon tkngmuon = new GUI.TimKiemNguoiMuon();
            tkngmuon.Show();
        }
    }
}

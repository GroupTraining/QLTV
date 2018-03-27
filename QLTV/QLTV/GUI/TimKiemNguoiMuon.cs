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
    public partial class TimKiemNguoiMuon : Form
    {
        Bus bus = new Bus();
        public TimKiemNguoiMuon()
        {
            InitializeComponent();
            dataGridViewNgmuon.DataSource = bus.get_ngmuon();
            dataGridViewNgmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewNgmuon.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewNgmuon.DataSource = bus.get_ngmuon(textGiatri.Text);
            dataGridViewNgmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewNgmuon.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewNgmuon.DataSource = bus.get_ngmuon();
            dataGridViewNgmuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewNgmuon.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.TracuuChoose tracuu = new GUI.TracuuChoose();
            tracuu.Show();
        }
    }
}

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

    public partial class TimkiemSach : Form
    {
        Bus bus = new Bus();
        public TimkiemSach()
        {
            InitializeComponent();
            dataGridViewSach.DataSource = bus.get_sach();
            dataGridViewSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSach.DataSource = bus.get_sach(textGiatri.Text);
            dataGridViewSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewSach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            dataGridViewSach.DataSource = bus.get_sach();
            dataGridViewSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}

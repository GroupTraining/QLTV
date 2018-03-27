using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace QLTV.GUI
{
    public partial class AddChiTietSach : Form
    {
        Bus bus = new Bus();
        public AddChiTietSach()
        {
            InitializeComponent();
            dataGridViewX2.DataSource = bus.get_sach1();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            try
            {
                bus.addChiTietSach(txtMaSach1.Text, txtTenSach1.Text, txtTacGia1.Text, txtTheLoai1.Text, txtNXB1.Text, txtNgonNgu1.Text, txtLinhVuc1.Text, Convert.ToInt32(txtNamXB1.Text));
                dataGridViewX2.Refresh();
                dataGridViewX2.DataSource = bus.get_sach1();
                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Nhập Sai Dữ Liệu. Nhập Lại!");
            }
        }
    }
}

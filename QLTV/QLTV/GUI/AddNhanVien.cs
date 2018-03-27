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
    public partial class AddNhanVien : Form
    {
        Bus bus = new Bus();
        public AddNhanVien()
        {
            InitializeComponent();
            dataGridViewX1.DataSource = bus.get_nhanvien();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rdbNam.Checked == true)
            {
                gt = "Nam";
            }
            if (rdbNu.Checked == true)
            {
                gt = "Nữ";
            }
            try
            {
                bus.addNhanVien(txtMaNV.Text, txtTenNV.Text, gt, date.Text, txtSDT.Text);
                dataGridViewX1.Refresh();
                dataGridViewX1.DataSource = bus.get_nhanvien();
               
                MessageBox.Show("Đã thêm thành công");
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Nhập liệu sai!!!");
            }

        }
    }
}

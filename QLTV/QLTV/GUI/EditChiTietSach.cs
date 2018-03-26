﻿using System;
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
    public partial class EditChiTietSach : Form
    {
        Bus bus = new Bus();
        public EditChiTietSach()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void EditChiTietSach_Load(object sender, EventArgs e)
        {
            dgvChiTietSach.DataSource = bus.get_ChiTietSach();
            dgvChiTietSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa  thông tin Chi tiết sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

               bus.Update_CTS(txtMaSach.Text, txtTenSach.Text,txtTacGia.Text,txtTheLoai.Text,txtNhaXB.Text,txtNgonNgu.Text,txtLinhVuc.Text,txtNamXB.Text,txtMaVT.Text);
                MessageBox.Show("Chỉnh sửa thành công!!");
               
    
                dgvChiTietSach.DataSource = bus.get_ChiTietSach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa  thông tin Chi Tiết Sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.del_CTS(txtMaSach.Text,txtMaVT.Text);
                MessageBox.Show("Xóa thành công!!");
                dgvChiTietSach.DataSource = bus.get_ChiTietSach();
            }
        }

        private void dgvChiTietSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
                txtMaSach.Text = "";
                txtTenSach.Text = "";
                txtTacGia.Text = "";
                txtTheLoai.Text = "";
                txtNhaXB.Text = "";
                txtNgonNgu.Text = "";
                txtLinhVuc.Text = "";
                txtNamXB.Text = "";
                txtMaVT.Text = "";
                dgvChiTietSach.Refresh();
                dgvChiTietSach.DataSource = bus.get_ChiTietSach();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa  thông tin Chi Tiết Sách này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.del_CTS(txtMaSach.Text,txtMaVT.Text);
                MessageBox.Show("Xóa thành công!!");
                dgvChiTietSach.Refresh();
                dgvChiTietSach.DataSource = bus.get_ChiTietSach();
            }
        }

        private void dgvChiTietSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Enabled = false;
            txtMaVT.Enabled = false;
            int rowindex = dgvChiTietSach.CurrentCell.RowIndex;
            int columnindex = dgvChiTietSach.CurrentCell.ColumnIndex;
            txtMaSach.Text = dgvChiTietSach.Rows[rowindex].Cells[0].Value.ToString();
            txtTenSach.Text = dgvChiTietSach.Rows[rowindex].Cells[1].Value.ToString();
            txtTacGia.Text = dgvChiTietSach.Rows[rowindex].Cells[2].Value.ToString();
            txtTheLoai.Text = dgvChiTietSach.Rows[rowindex].Cells[3].Value.ToString();
            txtNhaXB.Text = dgvChiTietSach.Rows[rowindex].Cells[4].Value.ToString();
            txtNgonNgu.Text = dgvChiTietSach.Rows[rowindex].Cells[5].Value.ToString();
            txtLinhVuc.Text = dgvChiTietSach.Rows[rowindex].Cells[6].Value.ToString();
            txtNamXB.Text = dgvChiTietSach.Rows[rowindex].Cells[7].Value.ToString();
            txtMaVT.Text = dgvChiTietSach.Rows[rowindex].Cells[8].Value.ToString();

        }
    }
}

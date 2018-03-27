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
using DAL;
namespace QLTV.GUI
{
    public partial class EditSinhVien : Form
    {
        Bus bus = new Bus();
        public EditSinhVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditSinhVien_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = bus.get_SinhVien();
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            bool gioitinh = true;
            if (rdb_nam.Checked == true)
            {
                gioitinh = false;
            }
            else
            {
                gioitinh = true;
            }
            if (MessageBox.Show("Bạn có muốn sửa  thông tin sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.EditSinhVien(txtMaSV.Text, txtTenSV.Text, gioitinh, Convert.ToDateTime(dtbBirtday.Text), txtSoDT.Text);
                MessageBox.Show("Chỉnh sửa thành công!!");
                txtMaSV.Text = "";
                txtTenSV.Text = "";
                txtSoDT.Text = "";
                rdb_nam.Checked = false;
                rdb_nu.Checked = false;
                dtbBirtday.Text = "";
                dgvSinhVien.Refresh();
                dgvSinhVien.DataSource = bus.get_SinhVien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa  thông tin sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.DelSinhVien(txtMaSV.Text);
                MessageBox.Show("Xóa thành công!!");
                dgvSinhVien.Refresh();
                dgvSinhVien.DataSource = bus.get_SinhVien();
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvSinhVien.CurrentCell.RowIndex;
            int columnindex = dgvSinhVien.CurrentCell.ColumnIndex;
            txtMaSV.Enabled = false;
            txtMaSV.Text = dgvSinhVien.Rows[rowindex].Cells[0].Value.ToString();
            txtTenSV.Text = dgvSinhVien.Rows[rowindex].Cells[1].Value.ToString();

            if (dgvSinhVien.Rows[rowindex].Cells[2].Value.ToString() == "True")
                rdb_nu.Checked = true;
            else
                rdb_nam.Checked = true;

            dtbBirtday.Text = dgvSinhVien.Rows[rowindex].Cells[3].Value.ToString();
            txtSoDT.Text = dgvSinhVien.Rows[rowindex].Cells[4].Value.ToString();
        }
    }
}

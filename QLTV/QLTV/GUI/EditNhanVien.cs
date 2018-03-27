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
    public partial class EditNhanVien : Form
    {
        Bus bus = new Bus();
        public EditNhanVien()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = bus.get_infoPersonal();
            dataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewX1.CurrentCell.RowIndex;
            int columnindex = dataGridViewX1.CurrentCell.ColumnIndex;
            txt_id.Enabled = false;
            txt_id.Text = dataGridViewX1.Rows[rowindex].Cells[0].Value.ToString();
            txt_name.Text = dataGridViewX1.Rows[rowindex].Cells[1].Value.ToString();
            
            if (dataGridViewX1.Rows[rowindex].Cells[2].Value.ToString() == "True")
                rdb_nu.Checked = true;
            else
                rdb_nam.Checked = true;

            dateNS.Text = dataGridViewX1.Rows[rowindex].Cells[3].Value.ToString();
            txt_phone.Text = dataGridViewX1.Rows[rowindex].Cells[4].Value.ToString();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            bool gt = true;
            if(rdb_nam.Checked == true)
            {
                gt = false;
            }
            else
            {
                gt = true;
            }
            if (MessageBox.Show("Bạn có muốn sửa  thông tin Nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.EditNhanVien(txt_id.Text, txt_name.Text, gt, Convert.ToDateTime(dateNS.Text), txt_phone.Text);
                MessageBox.Show("Chỉnh sửa thành công!!");
                txt_id.Text = "";
                txt_name.Text = "";
                txt_phone.Text = "";
                rdb_nam.Checked = false;
                rdb_nu.Checked = false;
                dateNS.Text = "";
                dataGridViewX1.Refresh();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa  thông tin Nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.DelNhanVien(txt_id.Text);
                MessageBox.Show("Xóa thành công!!");
                dataGridViewX1.Refresh();
            }
        }
    }
}

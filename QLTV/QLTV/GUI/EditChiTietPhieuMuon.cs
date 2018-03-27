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
    public partial class EditChiTietPhieuMuon : Form
    {
        Bus bus = new Bus();
        public EditChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        private void EditChiTietPhieuMuon_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = bus.get_CTThongTinPM();
            dataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mapm.Enabled = false;
            txt_masach.Enabled = false;
            int rowindex = dataGridViewX1.CurrentCell.RowIndex;
            int columnindex = dataGridViewX1.CurrentCell.ColumnIndex;
            txt_mapm.Text = dataGridViewX1.Rows[rowindex].Cells[0].Value.ToString();
            txt_masach.Text = dataGridViewX1.Rows[rowindex].Cells[1].Value.ToString();
            date_ngaymuon.Text = dataGridViewX1.Rows[rowindex].Cells[2].Value.ToString();
            date_hanmuon.Text = dataGridViewX1.Rows[rowindex].Cells[3].Value.ToString();
            if(dataGridViewX1.Rows[rowindex].Cells[4].Value == null)
            {
                date_ngaytra.Text = dataGridViewX1.Rows[rowindex].Cells[3].Value.ToString();
            }else
            {
                date_ngaytra.Text = dataGridViewX1.Rows[rowindex].Cells[4].Value.ToString();
            }
            if(dataGridViewX1.Rows[rowindex].Cells[5].Value == null)
            {
                txt_tienphat.Text = "0";
            }
            else
            {
                txt_tienphat.Text = dataGridViewX1.Rows[rowindex].Cells[5].Value.ToString();
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa  thông tin Chi tiết phiếu mượn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.Update_TTPM(txt_mapm.Text,date_ngaymuon.Text,date_hanmuon.Text,date_ngaytra.Text,txt_tienphat.Text);
                MessageBox.Show("Chỉnh sửa thành công!!");
                txt_mapm.Text = "";
                txt_masach.Text = "";
                txt_tienphat.Text = "";
                dataGridViewX1.DataSource = bus.get_CTThongTinPM();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa  thông tin Phiếu Mượn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                bus.del_TTPM(txt_mapm.Text);
                MessageBox.Show("Xóa thành công!!");
                dataGridViewX1.DataSource = bus.get_CTThongTinPM();
            }
        }
    }
}

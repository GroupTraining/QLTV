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
    public partial class ThongKe : Form
    {
        Bus bus = new Bus();
        DataDiagramDataContext data = new DataDiagramDataContext();
        public ThongKe()
        {
            InitializeComponent();
            dataGridViewX1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            comboBoxDeMuc.Items.Add("[Đề Mục]");
            comboBoxDeMuc.Items.Add("Sách");
            comboBoxDeMuc.Items.Add("Phiếu Mượn Trả");
            comboBoxDeMuc.SelectedItem = "[Đề Mục]";

            comboBoxTieuChi.Items.Add("[Tiêu Chí]");
            comboBoxTieuChi.SelectedItem = "[Tiêu Chí]";

            comboBoxChiTiet.Items.Add("[Nội Dung]");
            comboBoxChiTiet.SelectedItem = "[Nội Dung]";
        }
        private void comboBoxDeMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTieuChi.Items.Clear();
            comboBoxChiTiet.Items.Clear();
            comboBoxTieuChi.Items.Add("[Tiêu Chí]");
            comboBoxTieuChi.SelectedItem = "[Tiêu Chí]";

            comboBoxChiTiet.Items.Add("[Nội Dung]");
            comboBoxChiTiet.SelectedItem = "[Nội Dung]";
            if (comboBoxDeMuc.Text == "Sách")
            {
                comboBoxChiTiet.Show();
                comboBoxTieuChi.Items.Add("Thể Loại");
                comboBoxTieuChi.Items.Add("Lĩnh Vực");
            }else if (comboBoxDeMuc.Text == "Phiếu Mượn Trả")
            {
                comboBoxChiTiet.Hide();
                comboBoxTieuChi.Items.Add("Sách đã trả");
                comboBoxTieuChi.Items.Add("Sách chưa trả");
            }
        }

        private void comboBoxTieuChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxChiTiet.Items.Clear();
            comboBoxChiTiet.Items.Add("[Nội Dung]");
            comboBoxChiTiet.SelectedItem = "[Nội Dung]";
            var datas = from sach in data.ChiTietSaches
                      select sach;
            if (comboBoxTieuChi.Text == "Thể Loại")
            {
                foreach (var data in datas)
                {
                    comboBoxChiTiet.Items.Add(data.TheLoai);
                }
            }
            else if (comboBoxTieuChi.Text == "Lĩnh Vực")
            {
                foreach (var data in datas)
                {
                    comboBoxChiTiet.Items.Add(data.LinhVuc);
                }
            } 
        }

       
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (comboBoxTieuChi.Text == "Thể Loại")
            {
                dataGridViewX1.DataSource = bus.ThongKeSachTheoTheLoai(comboBoxChiTiet.GetItemText(comboBoxChiTiet.SelectedItem));
            }
            else if (comboBoxTieuChi.Text == "Lĩnh Vực")
            {
                dataGridViewX1.DataSource = bus.ThongKeSachTheoLinhVuc(comboBoxChiTiet.GetItemText(comboBoxChiTiet.SelectedItem));
            }
            else if (comboBoxTieuChi.Text == "Sách đã trả")
            {
                dataGridViewX1.DataSource = bus.ThongKePhieuDaTra();
            }
            else if (comboBoxTieuChi.Text == "Sách chưa trả")
            {
                dataGridViewX1.DataSource = bus.ThongKePhieuChuaTra();
            }


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.Main mainchinh = new GUI.Main();
            mainchinh.Show();
        }
    }
}

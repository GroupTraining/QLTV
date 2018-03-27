using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonTracuu_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.TracuuChoose tracuu = new GUI.TracuuChoose();
            tracuu.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI.ThongKe tracuu = new GUI.ThongKe();
            tracuu.Show();
        }
    }
}

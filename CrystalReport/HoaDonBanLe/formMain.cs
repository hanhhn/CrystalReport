using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HoaDonBanLe.Report;

namespace HoaDonBanLe
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hoaDonBanLeDataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.hoaDonBanLeDataSet.SANPHAM);
            // TODO: This line of code loads data into the 'hoaDonBanLeDataSet.SANPHAM' table. You can move, or remove it, as needed.

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            formReport f = new formReport();
            f.ShowDialog();
        }
    }
}

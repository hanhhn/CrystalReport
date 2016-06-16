using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApplication.CrystalReportDataSetTableAdapters;

namespace WindowsApplication
{
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
        }

        private void MainF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crystalReportDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.crystalReportDataSet.Product);
            try
            {
                ProductTableAdapter adapter = new ProductTableAdapter();
                DataTable dt = (DataTable)adapter.GetAll();


                CrystalReport1 cr1 = new CrystalReport1();
                cr1.SetDataSource(dt);
                crystalReportViewer1.ReportSource = cr1;


                CrystalReport2 cr2 = new CrystalReport2();
                cr2.SetDataSource(dt);
                crystalReportViewer2.ReportSource = cr2;

                CrystalReport3 cr3 = new CrystalReport3();
                cr3.SetDataSource(dt);
                crystalReportViewer3.ReportSource = cr3;

                CrystalReport4 cr4 = new CrystalReport4();
                cr4.SetDataSource(dt);
                crystalReportViewer4.ReportSource = cr4;

                CrystalReport5 cr5 = new CrystalReport5();
                cr5.SetDataSource(dt);
                crystalReportViewer5.ReportSource = cr5;

                CrystalReport6 cr6 = new CrystalReport6();
                cr6.SetDataSource(dt);
                crystalReportViewer6.ReportSource = cr6;

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

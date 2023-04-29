using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase2
{
    public partial class Form1 : Form
    {
        CrystalReport3 cr1;
        CrystalReport4 cr2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cr1 = new CrystalReport3();
            cr2 = new CrystalReport4();
        }
        private void report_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr2;
        }

        private void tax_Click_1(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr1;
        }

       
    }
}

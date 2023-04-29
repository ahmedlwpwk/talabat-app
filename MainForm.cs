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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void finditem_Click(object sender, EventArgs e)
        {
            Find_Items f1 = new Find_Items();
            f1.ShowDialog();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            Order f2 = new Order();
            f2.ShowDialog();
        }

        private void drivers_Click(object sender, EventArgs e)
        {
            driver f3 = new driver();
            f3.ShowDialog();
        }

        private void user_Click(object sender, EventArgs e)
        {
            USERS f4 = new USERS();
            f4.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f5 = new Form1();
            f5.ShowDialog();
        }
    }
}

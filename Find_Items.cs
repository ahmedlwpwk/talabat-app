using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
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
    public partial class Find_Items : Form
    {
        OracleDataAdapter adpt;
        OracleCommandBuilder bldr;
        DataSet dt;
        OracleConnection conn;
        String ordb = "Data source=orcl; User Id=scott; Password=tiger;";
        public Find_Items()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();


        }
        private void Find_Click(object sender, EventArgs e)
        {
            View.Rows.Clear();
            String commandstr = "select sup_id , sname, hotline, address, stype from supplier where stype=:c";
            adpt = new OracleDataAdapter(commandstr, ordb);
            adpt.SelectCommand.Parameters.Add(":c", search.Text);
            dt = new DataSet();
            adpt.Fill(dt);
            View.DataSource = dt.Tables[0];
        }

        private void add_Click(object sender, EventArgs e)
        {

            bldr = new OracleCommandBuilder(adpt);
            adpt.Update(dt.Tables[0]);


        }
    }


}
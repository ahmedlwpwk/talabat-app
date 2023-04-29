using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Phase2
{
    public partial class driver : Form
    {
        string ordb = "data source=orcl; user id=scott; password=tiger;";
        OracleConnection conn;

        public driver()
        {
            InitializeComponent();
        }

        private void driver_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select D_ID from Drivers";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_d_id.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cmb_d_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GetDriverOrderCount";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", cmb_d_id.SelectedItem);
            cmd.Parameters.Add("count", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            txt_o_count.Text = cmd.Parameters["count"].Value.ToString();
        }

        private void txt_o_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

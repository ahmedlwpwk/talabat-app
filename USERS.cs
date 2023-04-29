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
    public partial class USERS : Form
    {
        string ordb = "data source = orcl; user id=scott;Password=tiger;";
        OracleConnection conn;


        public USERS()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select UserID from Users";
            cmd.CommandType = CommandType.Text;



            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_u_id.Items.Add(dr[0]);
            }
            dr.Close();
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select UName from Users where UserID=:id ";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", cmb_u_id.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_u_name.Text = dr[0].ToString();
            }
            dr.Close();
        }






        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_u_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Users values (:id,:name,:email,:password,:phone,:address)";
            cmd.Parameters.Add("id", cmb_u_id.Text);
            cmd.Parameters.Add("name", txt_u_name.Text);
            cmd.Parameters.Add("email", txt_u_email.Text);
            cmd.Parameters.Add("password", txt_u_pass.Text);
            cmd.Parameters.Add("phone", txt_u_number.Text);
            cmd.Parameters.Add("address", txt_u_address.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                cmb_u_id.Items.Add(cmb_u_id.Text);
                MessageBox.Show("New User is added");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

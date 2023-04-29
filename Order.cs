using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Phase2
{
    public partial class Order : Form
    {
        string ordb = "Data Source = orcl ;User Id = scott ; Password = tiger ; ";
        OracleConnection connection;

        public Order()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ordb);
            connection.Open();
            dataGridView1.Columns.Add("orderid", "Order Id");
            dataGridView1.Columns.Add("itemname", "Items Name");
            dataGridView1.Columns.Add("DESCRIPTION", "Description");
            dataGridView1.Columns.Add("PRICE", "Price");

        }


        private void btn_showCopies_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = connection;
            oracleCommand.CommandText = "GetOrdersByCustomer";
            oracleCommand.CommandType = CommandType.StoredProcedure;
            oracleCommand.Parameters.Add("p_user_id", uer_id.Text);
            oracleCommand.Parameters.Add("p_orders", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = oracleCommand.ExecuteReader();

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(),
                    dr[2].ToString(), dr[3].ToString());
                //dataGridView1.Columns.Add("itemid", "itemid");
                //dataGridView1.Rows.Add("orderid:" +  + "itemid:"+ dr[1].ToString());

            }
            //DataTable dataTable = new DataTable();
            //dataTable.Load(dr);

            ////DataSet ds = new DataSet();
            ////ds.Tables.Add((DataTable)dr[0]);
            //dataGridView1.DataSource = dataTable;
            dr.Close();
            //OracleCommand oracleCommand = new OracleCommand();
            //oracleCommand.Connection = connection;
            //oracleCommand.CommandText = "GetOrdersByCustomer";
            //oracleCommand.CommandType = CommandType.StoredProcedure;
            //oracleCommand.Parameters.Add("p_user_id", uer_id.Text);
            //oracleCommand.Parameters.Add("p_orders", OracleDbType.Varchar2, ParameterDirection.Output);
            //int r = oracleCommand.ExecuteNonQuery();
            //dataGridView1.Rows.Add(oracleCommand.Parameters["p_orders"].Value.ToString());
        }
    }

}
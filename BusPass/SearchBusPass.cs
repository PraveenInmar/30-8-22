using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusPass
{
    public partial class SearchBusPass : Form
    {
        public SearchBusPass()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBusPass_Load(object sender, EventArgs e)
        {

        }

        private void SNInpu_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //step-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnection1 = new SqlConnection(connection);
            sqlconnection1.Open();

            //step-2
            string query = "select * from BusPass";
            SqlCommand sqlcmd = new SqlCommand(query,sqlconnection1);
            DataSet dset = new DataSet();
            SqlDataAdapter adapeter = new SqlDataAdapter(sqlcmd);
            adapeter.Fill(dset);

            //step-3
            dataGridView1.DataSource = dset.Tables[0];

            //step-4
            sqlconnection1.Close();


        }
    }
}

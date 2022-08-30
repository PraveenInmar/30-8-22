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
    public partial class BusPassForm : Form
    {
        public BusPassForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
           


            string gender = "";
            string status = "";

            if (MaleradioButton1.Checked)
            {
                gender = "Mail";
            }
            else
            {
                gender = "Femail";
            }
            
            if (MarriedradioButton.Checked)
            {
                status = "Married";
            }
            else
            {
                status = "Unmarried";
            }
            string fn = "";
            string ln = "";
            string age = "";
            string add = "";
            VerifyBuspass vbp = new VerifyBuspass();
            {
                vbp.setValues(fn, ln, age, add, gender, status);
                vbp.Show();
            }

            //stop-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnection = new SqlConnection(connection);
            sqlconnection.Open();

            //stop-2
            string query = "insert into BusPass values('" + BPFN + "','"
                                                         + BPLN + "','"
                                                         + BPA + "','"
                                                         + BPM + "','"
                                                         + BPADD + "','"
                                                         + BPG + "','"
                                                         + BPS + "')";
            SqlCommand sqlcmd = new SqlCommand(query,sqlconnection);
            sqlcmd.ExecuteNonQuery();

            //step-3
            sqlconnection.Close();
        }

        private void BusPassForm_Load(object sender, EventArgs e)
        {

        }
    }
}

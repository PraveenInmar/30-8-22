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
            if(RadioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            string status = "";
            if(MarriedradioButton.Checked)
            {
                status = "Married";
            }
            else
            {
                status = "UnMarried";
            }
            //stop-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnection1 = new SqlConnection(connection);
            sqlconnection1.Open();

            //stop-2
            

            string query = "insert into BusPass values('"+BPFN.Text+ "','" + BPLN.Text + "','" + BPA.Text + "','" + BPM.Text + "','" + BPADD.Text + "','" + gender+ "','" + status + "')";
            SqlCommand sqlcmd = new SqlCommand(query,sqlconnection1);
            int a =sqlcmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("insert successfully....");
            }
            else
            {
                MessageBox.Show("insertion fales......");
            }

            //step-3
            sqlconnection1.Close();


            
            VerifyBuspass vbp = new VerifyBuspass();
            {
                vbp.setValues(BPFN.Text, BPLN.Text, BPA.Text,BPM.Text,BPM.Text, gender, status);
                vbp.Show();
            }
        }

        private void BusPassForm_Load(object sender, EventArgs e)
        {
            //step-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnection1 = new SqlConnection(connection);
            sqlconnection1.Open();

            //step-2
            string query = "select * from BusPass";
            SqlCommand sqlcmd = new SqlCommand(query, sqlconnection1);
            DataSet dset = new DataSet();
            SqlDataAdapter adapeter = new SqlDataAdapter(sqlcmd);
            adapeter.Fill(dset);

            //step-3
            dtgcustomer.DataSource = dset.Tables[0];

            //step-4
            sqlconnection1.Close();
        }
        private void dtgcustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //In this section we will get the  customer code which
            //id selected
            string customerselected = dtgcustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            //e. rowindex get the selected row 
            //zero to cells gets the customer code
            DisplayCustomer(customerselected);
        }
        private void DisplayCustomer(string customerCode)
        {
            //select the customer and display the same on the screen
            //step-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnection1 = new SqlConnection(connection);
            sqlconnection1.Open();

            //step-2
            //select the records and display it on the screen
            string query = "select * from BusPass where FirstName='" + customerCode + "'";
            SqlCommand sqlcmd = new SqlCommand(query, sqlconnection1);
            DataSet dset = new DataSet();
            SqlDataAdapter adapeter = new SqlDataAdapter(sqlcmd);
            adapeter.Fill(dset);

            //step-3
            string strFirstName = dset.Tables[0].Rows[0][0].ToString();
            string strLastName = dset.Tables[0].Rows[0][1].ToString();
            string strAge = dset.Tables[0].Rows[0][2].ToString();
            string strMobile = dset.Tables[0].Rows[0][3].ToString();
            string strAddress = dset.Tables[0].Rows[0][4].ToString();
            string strGender = dset.Tables[0].Rows[0][5].ToString();
            string strStatus = dset.Tables[0].Rows[0][6].ToString();

            BPFN.Text = strFirstName;
            BPLN.Text = strLastName;
            BPA.Text = strAge;
            BPM.Text = strMobile;
            BPADD.Text = strAddress;

            if((strGender.Length==0) || (strGender == "Male"))
            {
                RadioMale.Checked = true;
            }
            else
            {
                RadioFemale.Checked = true;
            }
            if((strStatus.Length==0)||(strStatus == "Married"))
            {
                MarriedradioButton.Checked = true;
            }
            else
            {
                UnMarriedradioButton.Checked = true;
            }
            




            //step-4
            sqlconnection1.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //the selected customer code will be deleted
            //select the customer and display the same on the screen
            //step-1
            string connection = "Data Source=IN-WIN-PKUMAR\\SQLEXPRESS;Initial Catalog=myCust;Integrated Security=True;Pooling=False";
            SqlConnection sqlconnection1 = new SqlConnection(connection);
            sqlconnection1.Open();

            //step-2
            //select the records and display it on the screen
            string query = "delete from BusPass where FirstName="+"'" + BPFN.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(query, sqlconnection1);

            sqlcmd.ExecuteNonQuery();

            sqlconnection1.Close();
        }
    
    }
}

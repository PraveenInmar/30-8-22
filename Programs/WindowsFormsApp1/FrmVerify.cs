using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmVerify : Form
    {
        public FrmVerify()
        {
            InitializeComponent();
        }

        private void FrmVerify_Load(object sender, EventArgs e)
        {

        }
        public void setValues(string FirstName, string LastName,string Age,string Gender,string Status)
        {
            VerifyFirstName.Text = FirstName;
            VerifyLastName.Text = LastName;
            VerifyAge.Text = Age;
            VerifyGender.Text = Gender;
            VerifyStatus.Text = Status;
        }
    }
}

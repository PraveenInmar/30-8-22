using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusPass
{
    public partial class VerifyBuspass : Form
    {
        public VerifyBuspass()
        {
            InitializeComponent();
        }

        private void VerifyBuspass_Load(object sender, EventArgs e)
        {

        }

        public void setValues(string FirstName, string LastName, string Age,string mobile, string Address, string gender, string status)
        {
          
            VFN.Text = FirstName;
            VLN.Text = LastName;
            VA.Text = Age;
            VM.Text = mobile;
            VADD.Text = Address;
            VG.Text = gender;
            VS.Text = status;
        }
    }
}

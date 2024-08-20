using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_Tr42
{
    public partial class frmSubmit : Form
    {
        public frmSubmit()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string str = "Hello " + txtUser.Text;
            MessageBox.Show(str);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            txtDescription.Text = "";
        }
    }
}

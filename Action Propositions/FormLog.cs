using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Action_Propositions
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void CheckBoxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPas.Checked == true)
            {
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "" && TxtPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "LOG IN Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
            }
            else if (Program.accountManager.Login(TxtUsername.Text, TxtPassword.Text))
            {
                TxtUsername.Text = "";
                TxtPassword.Text = "";
                Program.Form.SetUsername(Program.accountManager.GetCurrentUsername());
                MessageBox.Show("You have successfully logged into your account", "LOG IN Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password or Login is not correct, Please Re-enter", "LOG IN Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPassword.Text = "";
                TxtPassword.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}

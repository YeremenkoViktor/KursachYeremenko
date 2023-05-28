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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "" || TxtPassword.Text == "" || TxtConPas.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
            }
            else if (TxtConPas.Text == TxtPassword.Text)
            {
                if (Program.accountManager.IsCurrentUserAdmin())
                {
                    if (Program.accountManager.CreateAdminUser(TxtUsername.Text, TxtConPas.Text))
                    {
                        TxtUsername.Text = "";
                        TxtPassword.Text = "";
                        TxtConPas.Text = "";
                        Program.Form.SetUsername(Program.accountManager.GetCurrentUsername());
                        MessageBox.Show("Your Account Admin hes been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else MessageBox.Show("This name already exists", "Name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Program.accountManager.Register(TxtUsername.Text, TxtConPas.Text))
                {
                    TxtUsername.Text = "";
                    TxtPassword.Text = "";
                    TxtConPas.Text = "";
                    Program.Form.SetUsername(Program.accountManager.GetCurrentUsername());
                    MessageBox.Show("Your Account hes been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else MessageBox.Show("This name already exists", "Name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtConPas.Text = "";
                TxtPassword.Text = "";
                TxtPassword.Focus();
            }
        }

        private void CheckBoxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxShowPas.Checked == true)
            {
                TxtPassword.PasswordChar = '\0';
                TxtConPas.PasswordChar = '\0';
            }
            else
            {
                TxtPassword.PasswordChar = '•';
                TxtConPas.PasswordChar = '•';
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtUsername.Text = "";
            TxtPassword.Text = "";
            TxtConPas.Text = "";
            TxtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLog().Show();
            this.Hide();
        }
    }
}

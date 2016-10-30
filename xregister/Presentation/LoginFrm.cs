using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xregister.Presentation;
using Entities;
using Business;

namespace xregister
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountsManager accountsManager = new AccountsManager();
            Account account = new Account(txtUsername.Text, txtPassword.Text, Convert.ToInt32(txtPIN.Text));

            if(accountsManager.loginAccount(account))
            {
                RegisterFrm registerFRM = new RegisterFrm();
                registerFRM.Show();
            }
            else
            {
                MessageBox.Show("Username or Password invalid");
            }
        }
    }
}

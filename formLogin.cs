using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhap
{
    public partial class formLogin : Form
    {
        string username = "";
        string password = "";
        public formLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            
           if(isReal(txtUsername.Text, txtPassword.Text)) {
                
                Form1 frmMain = new Form1();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
           
        }
        bool isReal(string username, string password)
        {
            if (username == this.username && password == this.password) 
            {
                return true;
            }

            return false;
        }
    }
}

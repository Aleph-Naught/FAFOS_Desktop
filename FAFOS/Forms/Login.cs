using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FAFOS.Forms;

namespace FAFOS.Forms
{
    public partial class Login : Form
    {
        //Members----------------------------------------------------------------------

        //TODO: This is really lazy way to pass paramaters, and probs a security risk
        Users user;
        
        public int userid;
        //end todo

        private int LoginRetryCounter = 0;

        private bool _Authenticated = false;

        public bool Authenticated
        {
            get { return _Authenticated; }
            set { _Authenticated = value; }
        }
        private string _Username = "";

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public event EventHandler LoggedIn;
        public event EventHandler LogInClosed;

        //Functions---------------------------------------------------------------------
        public Login()
        {
            user = new Users();
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {

            if (LoginAttempt())
            {
                if (LoggedIn != null)
                    LoggedIn(sender, e);

            }

        }

        public bool LoginAttempt()
        {
            if (LoginRetryCounter < 2)
            {
                if (txtPassword.Text.Length > 0 && txtUsername.Text.Length > 0)
                {
                    if (UserAuthenticated(txtUsername.Text, txtPassword.Text))
                    {

                        return true;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Username or Password not recognised");
                        txtPassword.Text = "";
                        LoginRetryCounter++; // increment retry counter
                        return false;
                    }
                }
                else // password or username is empty
                {
                    System.Windows.Forms.MessageBox.Show("You need to enter both a username and a password to continue");
                    LoginRetryCounter++;
                    return false;
                }
            }
            else // too many attempts
            {
                System.Windows.Forms.MessageBox.Show("You have failed to remember your details \n Contact Administration for further instructions");
                System.Windows.Forms.Application.Exit();
                return false;
            }
        }

        private bool UserAuthenticated(string p, string p_2)
        {

            if (user.check(p, p_2))
            {
                userid = user.getId(p);
                Authenticated = true;
                return true;
            }
            return false;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO: This causes a weird graphical bug, try it
            if (!Authenticated)
                Application.Exit();
        }


    }
}

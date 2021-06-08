using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_House
{
    public partial class LogIn : Form
    {
        
        private StudentHouse sh;
        private Rules r;
        private User user;
        public LogIn()
        {
            InitializeComponent();
            this.sh = new StudentHouse();
            this.r = new Rules();
        }
        private void ChangeForm(int userNumber, String password)
        {
            User u = this.sh.GetUser(userNumber, password);
            if (u.DeterminePassword == "@student")
            {
                StudentForm sf = new StudentForm(this, this.sh, u, this.r);
                sf.Show();
            }
            else if (u.DeterminePassword == "@admin")
            {
                AdminForm af = new AdminForm(this, this.sh, u, this.r);
                af.Show();
            }
            this.Visible = false;
        }
        private void Log()
        {
            int userNumber = int.Parse(this.tbUserNumber.Text.Trim());
            String password = this.tbPassword.Text.Trim();
            if (this.sh.CheckNumber(userNumber))
            {
                if (this.sh.CheckPassword(password))
                {
                    User u = this.sh.GetUser(userNumber, password);
                    if (u.Pending)
                    {
                        MessageBox.Show("Your account is still in pending! Please wait for approval from admin!");
                    }
                    else
                    {
                        if (u.Banned)
                        {
                            MessageBox.Show("Your account is currently banned! Please wait to be unbanned!");
                        }
                        else
                        {
                            this.ChangeForm(userNumber, password);
                        }
                    }
              

                }
                else
                {
                    MessageBox.Show(String.Format("This password does not exist in the database!"));
                }
            }
            else
            {
                MessageBox.Show(String.Format("The user number '{0}' does not exist!", userNumber));
            }
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Log();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn(this.sh, this);
            signIn.Show();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}

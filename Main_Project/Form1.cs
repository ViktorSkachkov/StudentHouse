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
    public partial class SignIn : Form
    {
        private StudentHouse sh;
        private LogIn login;

        public SignIn(StudentHouse sh, LogIn login)
        {
            InitializeComponent();
            this.sh = sh;
            this.login = login;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            int stNumber;
            if (!String.IsNullOrEmpty(tbFirstName.Text)&& !String.IsNullOrEmpty(tbSurname.Text)&& !String.IsNullOrEmpty(tbLastName.Text)&& !String.IsNullOrEmpty(tbEmail.Text)&& !String.IsNullOrEmpty(tbPassword.Text)&&
                    !String.IsNullOrEmpty(tbPassword.Text))
                {
                    string firstName = tbFirstName.Text.Trim();
                    string surname = tbSurname.Text.Trim();
                    string lastName = tbLastName.Text.Trim();
                    string email = tbEmail.Text.Trim();
                    string password = tbPassword.Text.Trim();
                    string repeatPassword = tbPassword.Text.Trim();
                    if (password == repeatPassword)
                {

                    var random = new Random();
                     stNumber = random.Next(1000, 9999);

                    this.sh.AddUser(1111, firstName, surname, lastName, email, password, "@student", true, false);

                    this.Hide();
                    MessageBox.Show($"{stNumber}");
                    login.ShowDialog();                        
                }
                
            }

            


          
            
        }
    }
}
    
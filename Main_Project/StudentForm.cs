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
    public partial class StudentForm : Form
    {
        private List<String> UserEvents;
        private StudentHouse studentHouse;
        private LogIn logIn;
        private User user;
        private Rules rules;
        public StudentForm(LogIn li, StudentHouse sh, User u, Rules r)
        {
            InitializeComponent();
            this.studentHouse = sh;
            this.logIn = li;
            this.user = u;
            this.rules = r;
            this.UserEvents = new List<string>();
            this.Fill();
            this.Update();
            this.WelcomeUser();
        }
        private void lblBack_Click(object sender, EventArgs e)
        {
            this.logIn.Show();
            this.Close();
        }
        private void Fill()
        {
            this.cbDay.Items.Clear();
            this.cbDay.Items.AddRange(this.studentHouse.GetDays().ToArray());
            this.UpdateEvents();
        }
        private void WelcomeUser()
        {
            String firstName = this.user.FirstName;
            String surname = this.user.Surname;
            String lastName = this.user.LastName;
            this.lblWelcome.Text = String.Format("Welcome back {0} {1} {2}!", firstName, surname, lastName);
        }
        private void Update()
        {
            this.lbRules.Items.Clear();
            this.lbRules.Items.AddRange(this.rules.GetRules.ToArray());
            this.lbDaily.Items.Clear();
            foreach(DayOrWeek d in this.studentHouse.GetAllDays(this.user))
            {
                this.lbDaily.Items.Add(d.GetInfo(this.user));
            }
        }
        private void UpdateEvents()
        {
            lbEvents.Items.Clear();
            lbEvents.Items.AddRange(UserEvents.ToArray());
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string Event = cbEvent.Text;
            string Day = cbDay.Text;
            string Time = cbTime.Text;

            UserEvents.Add(Event + " on " + Day + " at " + Time);
            UpdateEvents();
        }
        private void SendComplaint()
        {
            string complaintdescription = this.tbComp.Text.Trim();
            DateTime complaintdate = this.dtpDate.Value;
            Complaint complaintList = new Complaint(complaintdescription, complaintdate);
        }
        private void btnSendComplaint_Click(object sender, EventArgs e)
        {
            try
            {
                this.SendComplaint();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
    public partial class AdminForm : Form
    {
        private List<String[]> complaintList;
        private StudentHouse studentHouse;
        private List<String> UserEvents;
        private LogIn logIn;
        private User user;
        private Rules rules;
        private Random rand;
        public AdminForm(LogIn li, StudentHouse sh, User u, Rules r)
        {
            InitializeComponent();
            this.studentHouse = sh;
            this.logIn = li;
            this.user = u;
            this.rules = r;
            this.UserEvents = new List<string>();
            this.rand = new Random();
            this.UpdateRules();
            this.UpdateComplaints();
            this.Fill();
            this.WelcomeUser();
            this.RefreshPending();
            this.RefreshBann();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            String rule = this.tbAddRule.Text.Trim();
            if (rule == String.Empty)
            {
                MessageBox.Show(String.Format("There is nothing written for a rule!"));
            }
            else
            {
                if (!this.rules.CheckRule(rule))
                {
                    this.rules.AddRule(rule);
                    MessageBox.Show(String.Format("The rule {0} was successfully added!", rule));
                }
                else
                {
                    MessageBox.Show(String.Format("The rule {0} already exists!", rule));
                }
            }
            UpdateRules();
        }
        private void Remove()
        {
            String rule = this.lbRules.SelectedItem.ToString();
            this.rules.RemoveRule(rule);
            MessageBox.Show(String.Format("The rule {0} was successfully deleted!", rule));
            this.UpdateRules();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                this.Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Edit()
        {
            int index = this.lbRules.SelectedIndex;
            String oldRule = this.lbRules.SelectedItem.ToString();
            String newRule = this.tbEditRule.Text.Trim();
            if (newRule == String.Empty)
            {
                MessageBox.Show(String.Format("There is nothing written for a rule!"));
            }
            else
            {
                this.rules.EditRule(index, oldRule, newRule);
                this.rules.RemoveRule(oldRule);
                MessageBox.Show(String.Format("The rule '{0}' was successfully replaced with rule '{1}'", oldRule, newRule));
            }
            this.UpdateRules();
        }

        private void RefreshPending()
        {

            foreach (User u in studentHouse.GetAllUsers())
            {
                if (u.Pending)
                {
                    lbPending.Items.Add(u.UserNumber);
                }
            }
        }

        private void RefreshBann() {
            this.lbBanned.Items.Clear();
            foreach (User u in studentHouse.GetAllUsers())
            {
                if (u.Banned)
                {
                    this.lbBanned.Items.Add(u.UserNumber);
                }
            }
        }
        private void Fill()
        {
            this.cbDay.Items.Clear();
            this.cbDay.Items.AddRange(this.studentHouse.GetDays().ToArray());
            this.UpdateEvents();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Edit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.logIn.Show();
            this.Close();
        }
        private void WelcomeUser()
        {
            String firstName = this.user.FirstName;
            String surname = this.user.Surname;
            String lastName = this.user.LastName;
            this.lblWelcome.Text = String.Format("Welcome back {0} {1} {2}!", firstName, surname, lastName);
        }
        private void UpdateRules()
        {
            this.lbRules.Items.Clear();
            this.lbRules.Items.AddRange(this.rules.GetRules.ToArray());
        }
        private void UpdateComplaints()
        {
            this.complaintList = Complaint.GetComplaints();
            this.lbComp.Items.Clear();
            foreach (string[] complaint in complaintList)
            {
                string complaintDate = complaint[1];
                string complaintDesc = complaint[0];
                this.lbComp.Items.Add(complaintDate + ": " + complaintDesc);
            }
        }
        private void AssignRandomly()
        {
            this.studentHouse.ClearAllDays();
            foreach(Task task in this.studentHouse.GetAllTasks())
            {
                if (task.Type == "weekly")
                {
                    int i = this.rand.Next(0, this.studentHouse.GetAllUsers().Count - 1);
                    this.studentHouse.AddTask("This week", i, task);
                }
                else
                {
                    if(task.Type == "daily")
                    {
                        foreach (String day in this.studentHouse.GetDays())
                        {
                                int i = this.rand.Next(0, this.studentHouse.GetAllUsers().Count - 1);
                                this.studentHouse.AddTask(day, i, task);
                        }
                    }
                }
            }
            foreach (DayOrWeek d in this.studentHouse.GetAllDays(null))
            {
                if (d.Name == "Monday")
                {
                    this.lblMonday.Text += d.GetInfo();
                }
                if (d.Name == "Tuesday")
                {
                    this.lblTuesday.Text += d.GetInfo();
                }
                if (d.Name == "Wednesday")
                {
                    this.lblWednesday.Text += d.GetInfo();
                }
                if (d.Name == "Thursday")
                {
                    this.lblThursday.Text += d.GetInfo();
                }
                if (d.Name == "Friday")
                {
                    this.lblFriday.Text += d.GetInfo();
                }
                if (d.Name == "Saturday")
                {
                    this.lblSaturday.Text += d.GetInfo();
                }
                if (d.Name == "Sunday")
                {
                    this.lblSunday.Text += d.GetInfo();
                }
                if(d.Name == "This week")
                {
                    this.lblThisWeek.Text += d.GetInfo();
                }
            }
        }
        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                this.AssignRandomly();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbPending.SelectedItem);
         
            foreach (User user in studentHouse.GetAllUsers())
            {
                if (user.UserNumber == id)
                {
                    user.ChangePending();
                }
            }
            this.lbPending.Items.Clear();
            MessageBox.Show($"{id}" +  " approved");
            this.RefreshPending();
        }

        private void btnBann_Click(object sender, EventArgs e)
        {
            foreach (User user in studentHouse.GetAllUsers())
            {
                if (user.UserNumber == Convert.ToInt32(tbBannAccounts.Text))
                {
                    user.ChangeBanned();
                    MessageBox.Show($"{user.UserNumber}" + " banned");
                    this.RefreshBann();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbBanned.SelectedItem);

            foreach (User user in studentHouse.GetAllUsers())
            {
                if (user.UserNumber == Convert.ToInt32(this.lbBanned.SelectedItem))
                {
                    user.ChangeBanned();
                    MessageBox.Show($"{id}" + " unbanned");
                    this.RefreshBann();
                }
            }
        }
        private void Delete()
        {
            int id = Convert.ToInt32(this.lbBanned.SelectedItem);
            this.studentHouse.RemoveUser(id);
            this.lbBanned.Items.Clear();
            MessageBox.Show($"{id}" + " rejected");
            this.RefreshBann();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Delete();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void Deny()
        {
            int id = Convert.ToInt32(this.lbPending.SelectedItem);
            this.studentHouse.RemoveUser(id);
            this.lbPending.Items.Clear();
            MessageBox.Show($"{id}" + " rejected");
            this.RefreshPending();
        }
        private void btnDenied_Click(object sender, EventArgs e)
        {
            try
            {
                this.Deny();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearComp_Click(object sender, EventArgs e)
        {
            this.lbComp.Items.Clear();
        }
        private void RemoveComp()
        {
            int action = this.lbComp.SelectedIndex;
            if (action > -1)
            {
                this.complaintList.RemoveAt(action);
                Complaint.RemoveCom(action);
                this.lbComp.Items.RemoveAt(action);
            }
        }
        private void btnRemoveComp_Click(object sender, EventArgs e)
        {
            try
            {
                this.RemoveComp();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowPending()
        {
            int userNumber = Convert.ToInt32(this.lbPending.SelectedItem);
            User u = this.studentHouse.GetUser(userNumber);
            MessageBox.Show(u.FirstName + " " + u.Surname + " " + u.LastName);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ShowPending();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowBanned()
        {
            int userNumber = Convert.ToInt32(this.lbBanned.SelectedItem);
            User u = this.studentHouse.GetUser(userNumber);
            MessageBox.Show(u.FirstName + " " + u.Surname + " " + u.LastName);
        }
        private void btnShowBanned_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
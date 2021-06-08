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
        private StudentHouse sh;
        private List<String> UserEvents;
        private LogIn li;
        private User u;
        private Rules r;
        private Random rand;
        public AdminForm(LogIn li, StudentHouse sh, User u, Rules r)
        {
            InitializeComponent();
            this.sh = sh;
            this.li = li;
            this.u = u;
            this.r = r;
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
                if (!this.r.CheckRule(rule))
                {
                    this.r.AddRule(rule);
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
            this.r.RemoveRule(rule);
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
                this.r.EditRule(index, oldRule, newRule);
                this.r.RemoveRule(oldRule);
                MessageBox.Show(String.Format("The rule '{0}' was successfully replaced with rule '{1}'", oldRule, newRule));
            }
            this.UpdateRules();
        }

        private void RefreshPending()
        {

            foreach (User u in sh.GetAllUsers())
            {
                if (u.Pending)
                {
                    lbPending.Items.Add(u.UserNumber);
                }
            }
        }

        private void RefreshBann() {
            this.lbBanned.Items.Clear();
            foreach (User u in sh.GetAllUsers())
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
            this.cbDay.Items.AddRange(this.sh.GetDays().ToArray());
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
            this.li.Show();
            this.Close();
        }
        private void WelcomeUser()
        {
            String firstName = this.u.FirstName;
            String surname = this.u.Surname;
            String lastName = this.u.LastName;
            this.lblWelcome.Text = String.Format("Welcome back {0} {1} {2}!", firstName, surname, lastName);
        }
        private void UpdateRules()
        {
            this.lbRules.Items.Clear();
            this.lbRules.Items.AddRange(this.r.GetRules.ToArray());
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
            this.sh.ClearAllDays();
            foreach(Task task in this.sh.GetAllTasks())
            {
                if (task.Type == "weekly")
                {
                    int i = this.rand.Next(0, this.sh.GetAllUsers().Count - 1);
                    this.sh.AddTask("This week", i, task);
                }
                else
                {
                    if(task.Type == "daily")
                    {
                        foreach (String day in this.sh.GetDays())
                        {
                                int i = this.rand.Next(0, this.sh.GetAllUsers().Count - 1);
                                this.sh.AddTask(day, i, task);
                        }
                    }
                }
            }
            foreach (DayOrWeek d in this.sh.GetAllDays(null))
            {
                if (d.Name == "Monday")
                {
                    this.lblMonday.Text += d.GetInfo(null);
                }
                if (d.Name == "Tuesday")
                {
                    this.lblTuesday.Text += d.GetInfo(null);
                }
                if (d.Name == "Wednesday")
                {
                    this.lblWednesday.Text += d.GetInfo(null);
                }
                if (d.Name == "Thursday")
                {
                    this.lblThursday.Text += d.GetInfo(null);
                }
                if (d.Name == "Friday")
                {
                    this.lblFriday.Text += d.GetInfo(null);
                }
                if (d.Name == "Saturday")
                {
                    this.lblSaturday.Text += d.GetInfo(null);
                }
                if (d.Name == "Sunday")
                {
                    this.lblSunday.Text += d.GetInfo(null);
                }
                if(d.Name == "This week")
                {
                    this.lblThisWeek.Text += d.GetInfo(null);
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
         
            foreach (User u in sh.GetAllUsers())
            {
                if (u.UserNumber == id)
                {
                    u.Pending = false;
                }
            }
            this.lbPending.Items.Clear();
            MessageBox.Show($"{id}" +  " approved");
            this.RefreshPending();
        }

        private void btnBann_Click(object sender, EventArgs e)
        {
            foreach (User u in sh.GetAllUsers())
            {
                if (u.UserNumber == Convert.ToInt32(tbBannAccounts.Text))
                {
                    u.Banned = true;
                    MessageBox.Show($"{u.UserNumber}" + " banned");
                    this.RefreshBann();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbBanned.SelectedItem);

            foreach (User u in sh.GetAllUsers())
            {
                if (u.UserNumber == Convert.ToInt32(this.lbBanned.SelectedItem))
                {
                    u.Banned = false;
                    MessageBox.Show($"{id}" + " unbanned");
                    this.RefreshBann();
                }
            }
        }
        private void Delete()
        {
            int id = Convert.ToInt32(this.lbBanned.SelectedItem);
            this.sh.RemoveUser(id);
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
            this.sh.RemoveUser(id);
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
    }
}
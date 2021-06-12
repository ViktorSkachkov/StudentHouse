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
        private StudentHouse studentHouse;
        private LogIn logIn;
        private User user;
        private Rules rules;
        private List<String> UserEvents;
        private List<User> tempForUsers;
        public AdminForm(LogIn li, StudentHouse sh, User u, Rules r)
        {
            InitializeComponent();
            this.studentHouse = sh;
            this.logIn = li;
            this.user = u;
            this.rules = r;
            this.UserEvents = new List<string>();
            this.tempForUsers = new List<User>();
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
            this.lbComp.Items.Clear();
            foreach (Complaint c in this.studentHouse.GetComplaints())
            {
                this.lbComp.Items.Add(c.GetComplaint());
            }
        }
        private void FillWithTasks(String building)
        {
            this.lblMonday.Text = "";
            this.lblTuesday.Text = "";
            this.lblWednesday.Text = "";
            this.lblThursday.Text = "";
            this.lblFriday.Text = "";
            this.lblSaturday.Text = "";
            this.lblSunday.Text = "";
            this.lblThisWeek.Text = "";
            foreach (DayOrWeek d in this.studentHouse.GetAllDays(null))
            {
                if (d.Name == "Monday")
                {
                    this.lblMonday.Text += d.GetInfo(building);
                }
                if (d.Name == "Tuesday")
                {
                    this.lblTuesday.Text += d.GetInfo(building);
                }
                if (d.Name == "Wednesday")
                {
                    this.lblWednesday.Text += d.GetInfo(building);
                }
                if (d.Name == "Thursday")
                {
                    this.lblThursday.Text += d.GetInfo(building);
                }
                if (d.Name == "Friday")
                {
                    this.lblFriday.Text += d.GetInfo(building);
                }
                if (d.Name == "Saturday")
                {
                    this.lblSaturday.Text += d.GetInfo(building);
                }
                if (d.Name == "Sunday")
                {
                    this.lblSunday.Text += d.GetInfo(building);
                }
                if (d.Name == "This week")
                {
                    this.lblThisWeek.Text += d.GetInfo(building);
                }
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
                    user.Bann();
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
                    user.Unbann();
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
            string Event = cbEvent.SelectedItem.ToString();
            string Day = cbDay.SelectedItem.ToString();
            string Time = cbTime.SelectedItem.ToString();

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
            this.studentHouse.ClearComplaints();
            MessageBox.Show("All the complaints were cleared!");
        }
        private void RemoveComp()
        {
            int action = this.lbComp.SelectedIndex;
            if (action > -1)
            {
                this.lbComp.Items.RemoveAt(action);
                this.studentHouse.RemoveComplaint(action);
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
            MessageBox.Show(u.FirstName + " " + u.Surname + " " + u.LastName + " in building " + u.Building);
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
            MessageBox.Show(u.FirstName + " " + u.Surname + " " + u.LastName + " in " + u.Building);
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
        private void SeeTasks()
        {
            String building = this.cbBuilding.SelectedItem.ToString();
            this.FillWithTasks(building);
        }
        private void btnSeeTasks_Click(object sender, EventArgs e)
        {
            try
            {
                this.SeeTasks();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Answer()
        {
            int index = this.lbComp.SelectedIndex;
            Complaint complaint = this.studentHouse.GetComplaints()[index];
            User receiver = complaint.GetSender;
            String message = this.tbMessage.Text.Trim();
            if (receiver.AddAnswer(message))
            {
                throw new Exception("Answer successfully sent!");
            }
            else
            {
                throw new Exception("Write something in the text field!");
            }
        }
        private void btnAnswerAComplaint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Answer();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ShowBuildingStudents()
        {
            String building = this.cbMessageToBuilding.SelectedItem.ToString();
            this.lbShowStudentsFromSameBuilding.Items.Clear();
            this.tempForUsers.Clear();
            foreach (User u in this.studentHouse.GetUsersFromSameBuilding(building)) 
            {
                this.tempForUsers.Add(u);
                this.lbShowStudentsFromSameBuilding.Items.Add(u.GetInfo());
                    }
        }
        private void btnShowBuildingStudents_Click(object sender, EventArgs e)
        {
            try
            {
                this.ShowBuildingStudents();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SendMessageToSelectedStudent()
        {
            int index = this.lbShowStudentsFromSameBuilding.SelectedIndex;
            User u = this.tempForUsers[index];
            String comment = this.tbSendToSelected.Text.Trim();
            if(comment != "")
            {
                u.AddMessage(comment, this.user);
                throw new Exception("Message successfully sent!");
            }
            else
            {
                throw new Exception("Write something in the text field!");
            }
        }
        private void btnSendMessageToSelected_Click(object sender, EventArgs e)
        {
            try
            {
                this.SendMessageToSelectedStudent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SendToAll()
        {
            String building = this.cbMessageToBuilding.SelectedItem.ToString();
            String message = this.tbSendToSelected.Text.Trim();
            if (message != "")
            {
                foreach (User u in this.studentHouse.GetUsersFromSameBuilding(building))
                {
                    u.AddMessage(message, this.user);
                }
                throw new Exception("Message successfully sent!");
            }
            else
            {
                throw new Exception("Write something in the text field!");
            }
        }
        private void btnSendToAllStudentsFromBuilding_Click(object sender, EventArgs e)
        {
            try
            {
                this.SendToAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
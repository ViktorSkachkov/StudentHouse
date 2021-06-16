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
        private List<Event> UserEvents;
        private List<User> tempForUsers;
        private List<User> pendingUsers;
        private List<User> bannedUsers;
            
        private Random random;
        public AdminForm(LogIn li, StudentHouse sh, User u, Rules r)
        {
            InitializeComponent();
            this.studentHouse = sh;
            this.logIn = li;
            this.user = u;
            this.rules = r;
            this.UserEvents = new List<Event>();
            this.tempForUsers = new List<User>();
            this.pendingUsers = new List<User>();
            this.bannedUsers = new List<User>();
            this.random = new Random();
            this.UpdateRules();
            this.UpdateComplaints();
            this.Fill();
            this.WelcomeUser();
            this.RefreshPending();
            this.RefreshBann();
            this.UpdateEvents();
          
            
        }









        // SEPARATE STUFF//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void Fill()
        {
            this.UpdateEvents();
            this.cbDay.Items.Clear();
            this.cbDay.Items.AddRange(this.studentHouse.GetDays().ToArray());
            this.cbBuilding.Items.Clear();
            this.cbEventBuilding.Items.Clear();
            foreach (String building in Enum.GetNames(typeof(Buildings)))
            {
                this.cbBuilding.Items.Add(building);
                this.cbEventBuilding.Items.Add(building);
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


        // SEPARATE STUFF//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // RULES TAB //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void UpdateRules()
        {
            this.lbRules.Items.Clear();
            this.lbRules.Items.AddRange(this.rules.GetRules.ToArray());
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
        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // RULES TAB //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // PENDING/BANNED ACCOUNTS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //           REFRESHING METHODS
        private void RefreshPending()
        {
            this.lbPending.Items.Clear();
            this.pendingUsers.Clear();
            foreach (User u in studentHouse.GetAllUsers())
            {
                if (u.Pending)
                {
                    this.lbPending.Items.Add($"{u.LastName},{u.FirstName}:{u.UserNumber}");
                    this.pendingUsers.Add(u);
                }
            }
        }
         

        private void RefreshBann()
        {
            this.bannedUsers.Clear();
            this.lbBanned.Items.Clear();
            foreach (User u in this.studentHouse.GetAllUsers())
                if (u.Banned)
                {
                    this.bannedUsers.Add(u);
                    this.lbBanned.Items.Add($"{u.LastName},{u.FirstName}:{u.UserNumber}");

                }
        }

        //           REFRESHING METHODS
        //           BUTTONS


        
     

        private void btnApprove_Click(object sender, EventArgs e)
              {
            int index = this.lbPending.SelectedIndex;

            User u = this.pendingUsers[index];
            u.ChangePending();
            MessageBox.Show($"{this.pendingUsers[index].UserNumber}" + " approved");
            this.RefreshPending();
        }

        private void btnBann_Click(object sender, EventArgs e)
        {
            foreach (User user in studentHouse.GetAllUsers())
            {
                if (user.UserNumber == Convert.ToInt32(tbBannAccounts.Text))
                {
                    user.Bann();
                    MessageBox.Show($"{user.UserNumber} is banned");
                    this.RefreshBann();
                }
            }
        }


        private void btnDenied_Click(object sender, EventArgs e)
        {
            try
            {
                this.Deny();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnbann_Click(object sender, EventArgs e)
        {
            int index = this.lbBanned.SelectedIndex;

            User u = this.bannedUsers[index];
            u.Unbann();
            MessageBox.Show($"{this.bannedUsers[index].UserNumber} is unbanned!");
            this.lbBanned.Items.Clear();
            this.RefreshBann();
        }


               //           BUTTONS
       









        private void Deny()
        {
            int id = Convert.ToInt32(this.lbPending.SelectedItem);
            this.studentHouse.RemoveUser(id);
            this.lbPending.Items.Clear();
            MessageBox.Show($"{id}" + " rejected");
            this.RefreshPending();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        // PENDING/BANNED ACCOUNTS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // TASKS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // TASKS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // EVENTS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void UpdateEvents()
        {
            this.lbEvents.Items.Clear();
            this.UserEvents.Clear();
            foreach (String building in Enum.GetNames(typeof(Buildings)))
            {
                foreach (Event e in this.studentHouse.GetEvents(building))
                {
                    this.UserEvents.Add(e);
                    this.lbEvents.Items.Add(e.GetInfo(this.user) + " from building " + e.Building);
                }
            }
        }

        private void cbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        // EVENTS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // COMPLAINTS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void UpdateComplaints()
        {
            this.lbComp.Items.Clear();
            foreach (Complaint c in this.studentHouse.GetComplaints())
            {
                this.lbComp.Items.Add(c.GetComplaint());
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveComp()
        {
            int action = this.lbComp.SelectedIndex;
            if (action > -1)
            {
                this.studentHouse.RemoveComplaint(action);
                this.lbComp.Items.RemoveAt(action);
            }
        }

        private void btnRemoveComp_Click(object sender, EventArgs e)
        {
            try
            {
                this.RemoveComp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void btnClearComp_Click(object sender, EventArgs e)
        {
            this.lbComp.Items.Clear();
        }

        // COMPLAINTS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // SEND MESSAGE //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbMessageToBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (User u in studentHouse.GetAllUsers())
            {
                if (u.UserNumber == 4545) { MessageBox.Show($"{bannedUsers[0]}"); }
            }
        }


        private void SendMessageToSelectedStudent()
        {
            int index = this.lbShowStudentsFromSameBuilding.SelectedIndex;
            User user = this.tempForUsers[index];
            String comment = this.tbSendToSelected.Text.Trim();
            if (comment != "")
            {
                user.AddMessage(comment, this.user);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveEvent_Click(object sender, EventArgs e)
        {
            int index = this.lbEvents.SelectedIndex;
            Event eve = this.UserEvents[index];
            User u = eve.Organizer;
            String building = u.Building;
            this.studentHouse.RemoveEvent(eve);
            foreach (User student in this.studentHouse.GetUsersFromSameBuilding(building))
            {
                student.AddMessage("I deleted one of your events. If you have objections, please contact me by writing a complaint!", this.user);
            }
            MessageBox.Show("The event was successfully deleted!");
            this.UpdateEvents();
        }

        private void gbPending_Enter(object sender, EventArgs e)
        {

        }

        private void lblLogOutAdmin_Click(object sender, EventArgs e)
        {
            this.logIn.Show();
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void DeleteAccount()
        {
            int id = Convert.ToInt32(this.lbBanned.SelectedItem);
            this.studentHouse.RemoveUser(id);
            this.lbBanned.Items.Clear();
            MessageBox.Show($"{id}" + " rejected");
            this.RefreshBann();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.DeleteAccount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddEvent()
        {
            string Event = cbEvent.Text;
            string Day = cbDay.Text;
            string Time = cbTime.Text;
            User organizer = this.user;
            String building = this.cbEventBuilding.SelectedItem.ToString();

            this.studentHouse.AddEvent(this.user, Day, Time, Event, building);
            UpdateEvents();
            MessageBox.Show("Event successfully added!");
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddEvent();
            }
            catch(Exception ex)
            {

            }
        }


        // SEND MESSAGE  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



























    }
    }

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
            this.cbMessageToBuilding.Items.Clear();
            foreach (Building building in this.studentHouse.GetAllBuildings())
            {
                this.cbBuilding.Items.Add(building.Name);
                this.cbEventBuilding.Items.Add(building.Name);
                this.cbMessageToBuilding.Items.Add(building.Name);
            }
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
            if (this.lbRules.SelectedIndex > -1)
            {
                String rule = this.lbRules.SelectedItem.ToString();
                this.rules.RemoveRule(rule);
                MessageBox.Show(String.Format("The rule {0} was successfully deleted!", rule));
                this.UpdateRules();
            }
            else
            {
                throw new Exception("Select a rule!");
            }
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
            if (this.lbRules.SelectedIndex > -1)
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
            else
            {
                throw new Exception("Select a rule!");
            }
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
                    this.lbPending.Items.Add($"{u.LastName},{u.FirstName}:{u.UserNumber} from {u.Building}, room {u.Room}");
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
                    this.lbBanned.Items.Add($"{u.LastName},{u.FirstName}:{u.UserNumber} from {u.Building}, room {u.Room}");

                }
        }

        //           REFRESHING METHODS
        //           BUTTONS


        
     

        private void btnApprove_Click(object sender, EventArgs e)
              {
            if (this.lbPending.SelectedIndex > -1)
            {
                int index = this.lbPending.SelectedIndex;

                User u = this.pendingUsers[index];
                u.ChangePending();
                MessageBox.Show($"{this.pendingUsers[index].UserNumber}" + " approved");
                this.RefreshPending();
            }
            else
            {
                MessageBox.Show("Select an account!");
            }
        }
        private void Bann()
        {
            int userNumber = Convert.ToInt32(tbBannAccounts.Text);
            foreach (User user in studentHouse.GetAllUsers())
            {
                if (user.UserNumber == userNumber)
                {
                    user.Bann();
                    this.RefreshBann();
                    throw new Exception($"{user.UserNumber} is banned");
                }
            }
            throw new Exception("No account with this user number was found!");
        }
        private void btnBann_Click(object sender, EventArgs e)
        {
            try
            {
                this.Bann();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            if (this.lbBanned.SelectedIndex > -1)
            {
                int index = this.lbBanned.SelectedIndex;

                User u = this.bannedUsers[index];
                u.Unbann();
                MessageBox.Show($"{this.bannedUsers[index].UserNumber} is unbanned!");
                this.lbBanned.Items.Clear();
                this.RefreshBann();
            }
            else
            {
                MessageBox.Show("Select an account!");
            }
        }


               //           BUTTONS
       









        private void Deny()
        {
            if (this.lbPending.SelectedIndex > -1)
            {
                int index = this.lbPending.SelectedIndex;
                User u = this.pendingUsers[index];
                int studentNumber = u.UserNumber;
                this.studentHouse.RemoveUser(studentNumber);
                this.lbPending.Items.Clear();
                MessageBox.Show($"{studentNumber}" + " rejected");
                this.RefreshPending();
            }
            else
            {
                throw new Exception("Select an account!");
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        // PENDING/BANNED ACCOUNTS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // TASKS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void FillWithTasks(String building)
        {
            this.lbSeeTasks.Items.Clear();
            foreach (DayOrWeek d in this.studentHouse.GetAllDays(null))
            {
                    this.lbSeeTasks.Items.Add(d.GetInfo(building));
                this.lbSeeTasks.Items.Add("");
            }
        }
        private void SeeTasks()
        {
            if (this.cbBuilding.SelectedIndex > -1)
            {
                String building = this.cbBuilding.SelectedItem.ToString();
                this.FillWithTasks(building);
            }
            else
            {
                throw new Exception("Select a building!");
            }
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
            foreach (Building building in this.studentHouse.GetAllBuildings())
            {
                foreach (Event e in this.studentHouse.GetEvents(building.Name))
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
            if (this.lbComp.SelectedIndex > -1)
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
            else
            {
                throw new Exception("Select a comlaint!");
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
                    throw new Exception("Complaint successfully removed!");
                }
                else
                {
                    throw new Exception("Select a complaint to remove!");
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
            this.studentHouse.ClearComplaints();
            MessageBox.Show("All complaints were cleared!");
        }

        // COMPLAINTS //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // SEND MESSAGE //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ShowBuildingStudents()
        {
            if (this.cbMessageToBuilding.SelectedIndex > -1)
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
            else
            {
                throw new Exception("Select a building!");
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
            if (this.cbMessageToBuilding.SelectedIndex > -1)
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
            else
            {
                throw new Exception("Select a building!");
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
            if (this.lbShowStudentsFromSameBuilding.SelectedIndex > -1)
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
            else
            {
                throw new Exception("Select a student!");
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
            if (this.lbEvents.SelectedIndex > -1)
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
            else
            {
                MessageBox.Show("Select an event!");
            }
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
            if (this.lbBanned.SelectedIndex > -1)
            {
                int index = this.lbBanned.SelectedIndex;
                User u = this.bannedUsers[index];
                int studentNumber = u.UserNumber;
                this.studentHouse.RemoveUser(studentNumber);
                this.lbBanned.Items.Clear();
                MessageBox.Show($"{studentNumber}" + " rejected");
                this.RefreshBann();
            }
            else
            {
                throw new Exception("Select an account!");
            }
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
            if (Event != "" && Day != "" && Time != "" && this.cbEventBuilding.SelectedIndex > -1)
            {
                String building = this.cbEventBuilding.SelectedItem.ToString();

                this.studentHouse.AddEvent(this.user, Day, Time, Event, building);
                UpdateEvents();
                MessageBox.Show("Event successfully added!");
            }
            else
            {
                MessageBox.Show("Fill n the correct informaion!");
            }
        }
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddEvent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddBuilding()
        {
            String name = this.tbBuildingName.Text.Trim();
            int capacity = Convert.ToInt32(this.tbCapacity.Text.Trim());
            if (name != "")
            {
                this.studentHouse.AddBuilding(name, capacity);
            }
            else
            {
                throw new Exception("Fill in the correct information!");
            }
        }
        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddBuilding();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                this.Fill();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCapacity_Click(object sender, EventArgs e)
        {

        }


        // SEND MESSAGE  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



























    }
    }

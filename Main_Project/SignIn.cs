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
        private StudentHouse studentHouse;
        private LogIn login;

        public SignIn(StudentHouse sh, LogIn login)
        {
            InitializeComponent();
            this.studentHouse = sh;
            this.login = login;
            this.FillBuildings();
        }
        private void FillBuildings()
        {
            this.cbBuilding.Items.Clear();
            foreach(Building building in this.studentHouse.GetAllBuildings())
            {
                this.cbBuilding.Items.Add(building.Name);
            }
        }
        private void cbRoomRefresh()
        {

            int index = cbBuilding.SelectedIndex;
            Building building = this.studentHouse.GetBuilding(index);
            string buildingName = building.Name;
            int capacityCheck = building.Capacity;
            cbRooms.Items.Clear();

            List<User> users = this.studentHouse.GetUsersFromSameBuilding(buildingName);



            foreach (int room in building.GetRooms())
            {

                    cbRooms.Items.Add($"{room}");

            }

            foreach (User user in users)
            {
                if (building.Name == user.Building)
                {
                    cbRooms.Items.Remove($"{user.Room}");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Sign()
        {
            int stNumber;
            if (!String.IsNullOrEmpty(tbFirstName.Text) && !String.IsNullOrEmpty(tbSurname.Text) && !String.IsNullOrEmpty(tbLastName.Text) && !String.IsNullOrEmpty(tbEmail.Text) && !String.IsNullOrEmpty(tbPassword.Text) &&
                    !String.IsNullOrEmpty(tbPassword.Text))
            {
                string firstName = tbFirstName.Text.Trim();
                string surname = tbSurname.Text.Trim();
                string lastName = tbLastName.Text.Trim();
                string email = tbEmail.Text.Trim();
                string building = cbBuilding.SelectedItem.ToString().Trim();
                int room = Convert.ToInt32(cbRooms.SelectedItem.ToString());
                string password = tbPassword.Text.Trim();
                string repeatPassword = tbPassword.Text.Trim();
                if (password == repeatPassword)
                {

                    var random = new Random();
                    stNumber = random.Next(1000, 9999);
                    this.studentHouse.AddUser(stNumber, firstName, surname, lastName, email, building, room, password, "@student", true, false);
                    this.Hide();
                    MessageBox.Show($"{stNumber}");
                    login.Show();
                }
                else
                {
                    MessageBox.Show("The repeated password is not the same.");
                }
            }
            else
            {
                MessageBox.Show("Fill in the correct information.");
            }
            //temporary variables 
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
                 try
            {
                this.Sign();
            }
            catch(Exception)
            {
                MessageBox.Show("Please fill in all of the information above");
            }
        }

        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.login.Show();
            this.Close();
        }

        private void tbRepeatPassowrd_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbRooms.Items.Clear();
            this.cbRoomRefresh();
        }
    }
}
    
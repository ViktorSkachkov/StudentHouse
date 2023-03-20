using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    public class User
    {
        private int userNumber;
        private String firstName;
        private String surname;
        private String lastName;
        private String email;
        private String building;
        private int room;
        private String password;
        private String determinePassword;
        private bool pending;
        private bool banned;
        List<String> answers;
        List<String> messages;
        public User(int userNumber, String firstName, String surname, String lastName, String email, String building, int room, String password, String determinePassword, bool pending, bool banned)
        {
            this.userNumber = userNumber;
            this.firstName = firstName;
            this.surname = surname;
            this.lastName = lastName;
            this.email = email;
            this.building = building;
            this.room = room;
            this.password = password;
            this.determinePassword = determinePassword;
            this.pending = pending;
            this.banned = banned;
            this.answers = new List<String>();
            this.messages = new List<string>();
        }
        public int UserNumber
        {
            get { return this.userNumber; }
            private set { this.userNumber = value; }
        }
        public String FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }
        public String Surname
        {
            get { return this.surname; }
            private set { this.surname = value; }
        }
        public String LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }
        public String Email
        {
            get { return this.email; }
            private set { this.email = value; }
        }
        public String Password
        {
            get { return this.password; }
            private set { this.password = value; }
        }
        public String DeterminePassword
        {
            get { return this.determinePassword; }
            private set { this.determinePassword = value; }
        }
        public String Building
        {
            get { return this.building; }
            private set { this.building = value; }
        }
        public int Room
        {
            get { return this.room; }
            private set { this.room = value; }
        }
        public bool Pending
        { 
            get { return this.pending; }
            private set { this.pending = value; }
        }

        public bool Banned
        {
            get { return this.banned; }
            private set { this.banned = value; }
        }
        public void Bann()
        {
            this.banned = true;
        }
        public void Unbann()
        {
            this.banned = false;
        }
        public void ChangePending()
        {
            this.pending = !this.pending;
        }

        public void ChangeBanned()
        {
            this.banned = !this.banned;
        }

        public bool AddAnswer(String comment)
        {
            if (comment != "")
            {
                this.answers.Add(comment);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RemoveAnswer(int index)
        {
            this.answers.RemoveAt(index);
        }
        public List<String> GetAnswers()
        {
            return this.answers;
        }
        public void AddMessage(String comment, User user)
        {
                if(user.DeterminePassword == "@admin")
                {
                    comment = String.Format("{0}: from the admin", comment);
                }
                else
                {
                    comment = String.Format("{0}: from {1} {2} {3}", comment, user.FirstName, user.Surname, user.LastName);
                }
                this.messages.Add(comment);
        }
        public void RemoveMessage(int index)
        {
            this.messages.RemoveAt(index);
        }
        public List<String> GetMessages()
        {
            return this.messages;
        }
        public String GetInfo()
        {
            String holder = this.firstName + " " + this.Surname + " " + this.LastName + " " + this.UserNumber;
            return holder;
        }
    }
}

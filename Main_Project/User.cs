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
        private String password;
        private String determinePassword;
        private bool pending;
        private bool banned;
        public User(int userNumber, String firstName, String surname, String lastName, String email, String password, String determinePassword, bool pending, bool banned)
        {
            this.userNumber = userNumber;
            this.firstName = firstName;
            this.surname = surname;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.determinePassword = determinePassword;
            this.pending = pending;
            this.banned = banned;
        }
        public int UserNumber
        {
            get { return this.userNumber; }
        }
        public String FirstName
        {
            get { return this.firstName; }
        }
        public String Surname
        {
            get { return this.surname; }
        }
        public String LastName
        {
            get { return this.lastName; }
        }
        public String Email
        {
            get { return this.email; }
        }
        public String Password
        {
            get { return this.password; }
        }
        public String DeterminePassword
        {
            get { return this.determinePassword; }
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
        public void ChangeBanned()
        {
            this.banned = !this.banned;
        }
        public void ChangePending()
        {
            this.pending = !this.pending;
        }
    }
}

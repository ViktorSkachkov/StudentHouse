using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    public class Complaint
    {
        private string description;
        private DateTime time;
        private String building;
        private User sender;
        public Complaint(string description, DateTime time, String building, User sender)
        {
            this.description = description;
            this.time = time;
            this.building = building;
            this.sender = sender;
        }
            public String GetComplaint()
            {
                String holder = description + " " + time.ToString() + " from building " + building;
                return holder;
            }
        public String Building
        {
            get { return this.building; }
            private set { this.building = value; }
        }
        public User GetSender
        {
            get { return this.sender; }
            private set { this.sender = value; }
        }
    }
}

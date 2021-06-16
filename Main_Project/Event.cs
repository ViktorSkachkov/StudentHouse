using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    public class Event
    {
        private String building;
        private User organizer;
        private String day;
        private String time;
        private String name;
        public Event(User organizer, String day, String time, String name, String building)
        {
            this.organizer = organizer;
            this.day = day;
            this.time = time;
            this.name = name;
            this.building = building;
        }
        public User Organizer
        {
            get { return this.organizer; }
            private set { this.organizer = value; }
        }
        public String Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public String Building
        {
            get { return this.building; }
            private set { this.building = value; }
        }
        public String GetInfo(User u)
        {
            String holder = "";
            if (u == this.organizer)
            {
                holder = $"I will make {this.name} on {this.day} at {this.time}";
            }
            else
            {
                if (this.organizer.DeterminePassword == "@admin")
                {
                    holder = $"The admin will make {this.name} on {this.day} at {this.time}";
                }
                else
                {
                    holder = $"{this.organizer.FirstName} will make {this.name} on {this.day} at {this.time}";
                }
            }
            return holder;
        }



    }



}
    
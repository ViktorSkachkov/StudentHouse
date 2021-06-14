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
        public String Day
        {
            get { return this.day; }
            set { this.day = value; }
        }
        public String Time
        {
            get { return this.time; }
            private set { this.time = value; }
        }
        public String Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public String GetEvents()
        {
            String holder=$"{this.organizer} will make {this.name} on {this.day}, {this.time}";
            return holder;
        }



    }



}
    
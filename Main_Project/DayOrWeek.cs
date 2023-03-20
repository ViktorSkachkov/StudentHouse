using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    public class DayOrWeek
    {
        private String name;
        private List<User> students;
        private List<Task> tasks;
        public DayOrWeek(String name)
        {
            this.name = name;
            this.students = new List<User>();
            this.tasks = new List<Task>();
        }
        public void Add(User student, Task task)
        {
            this.students.Add(student);
            this.tasks.Add(task);
        }
        public void RemoveAll()
        {
            this.students.Clear();
            this.tasks.Clear();
        }
        public String Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public List<User> Students
        {
            get { return this.students; }
            private set { this.students = value; }
        }
        public List<Task> Tasks
        {
            get { return this.tasks; }
            private set { this.tasks = value; }
        }
        public int GetNumberOfTimes(User u)
        {
            int number = 0;
            foreach (User n in this.students)
            {
                if (n == u)
                {
                    number++;
                }
            }
            return number;
        }
        public String GetInfo(String building)
        {
            String holder = String.Format(" {0}: ", this.name);
                for (int i = 0; i < this.students.Count; i++)
                {
                    if (this.students[i].Building == building)
                    {
                        holder += String.Format("Student {0} will {1}. ", this.students[i].FirstName, this.tasks[i].Name);
                    }
                }
            return holder;
        }
        public String GetInfo(User u)
        {
            String holder = String.Format(" {0}: ", this.name);
                for (int i = 0; i < this.students.Count; i++)
                {
                    if (this.students[i] == u)
                    {
                        holder += String.Format("You will {0}. ", this.tasks[i].Name);
                    }
                }
            return holder;
        }
    }
}

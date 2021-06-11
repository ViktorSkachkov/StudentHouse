using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    public class StudentHouse
    {
        private List<DayOrWeek> days;
        private List<User> users;
        private List<Task> tasks;
        private List<Complaint> complaints;
        private List<Event> events;
        private Random rand;
        public StudentHouse()
        {
            this.users = new List<User>() { new User(4545, "Viktor", "Aleksandrov", "Skachkov", "viktor.skachkov01@gmail.com", "B1", "sulphur", "@student", false, false),
                                            new User(1234, "Johnny", "Brown", "Kerrigan", "j.kerriganY@gmail.com", "B2", "pas", "@student", true, false),
                                            new User(1, "Pavel", "Ivanov", "Vasilov", "pav.vasilov999@gmail.com", "admin", "admin", "@admin", false, false)};           
            this.days = new List<DayOrWeek>() { new DayOrWeek("Monday"), new DayOrWeek("Tuesday"), new DayOrWeek("Wednesday"), new DayOrWeek("Thursday"), new DayOrWeek("Friday"), new DayOrWeek("Saturday"), new DayOrWeek("Sunday"), new DayOrWeek("This week")};
            this.tasks = new List<Task>() { new Task("do the garbage disposal", "daily"), new Task("swipe the whole property", "daily"), new Task("clean the dishes", "daily"), new Task("clean the bathroom", "weekly"), new Task("clean the whole property", "weekly") };
            this.events = new List<Event>();
            this.complaints = new List<Complaint>();
            this.rand = new Random();
        }
        public void AddUser(int userNumber, String firstName, String surname, String lastName, String email, String building, String password, String determinePassword, bool pending, bool banned)
        {
                if (!this.CheckName(firstName, surname, lastName))
                {
                    if (!this.CheckEmail(email))
                    {
                        if (!this.CheckPassword(password))
                        {
                            this.users.Add(new User(userNumber, firstName, surname, lastName, email, building, password, determinePassword, pending, banned));
                        }//gorniq red kod ima problem s USER
                        else
                        {
                            throw new Exception("This password is already used by another user!");
                        }
                    }
                    else
                    {
                        throw new Exception("This email is already used by another user!");
                    }
                }
                else
                {
                    throw new Exception("This name is already used by another user!");
                }
        }
        public List<Complaint> GetComplaints()
        {
            return this.complaints;
        }
        public void AddComplaint(String complaintdescription, DateTime complaintdate, String building, User sender)
        {
            if (complaintdescription != "")
            {
                this.complaints.Add(new Complaint(complaintdescription, complaintdate, building, sender));
                throw new Exception("The complaint was successfully added!");
            }
            else
            {
                throw new Exception("Write something in the text field!");
            }
        }
        public void RemoveComplaint(int index)
        {
            this.complaints.RemoveAt(index);
            throw new Exception("The complaint was successfully removed!");
        }
        public void ClearComplaints()
        {
            this.complaints.Clear();
        }
        public void RemoveUser(int userNumber)
        {
            User u = this.users.Find(x => x.UserNumber == userNumber);
            String name = u.FirstName;
            this.users.Remove(u);
        }
        public bool CheckNumber(int userNumber)
        {
            return this.users.Exists(x => x.UserNumber == userNumber);
        }
        private bool CheckName(String firstName, String surname, String lastName)
        {
            return this.users.Exists(x => x.FirstName == firstName) && this.users.Exists(x => x.Surname == surname)
                && this.users.Exists(x => x.LastName == lastName);
        }
        public bool CheckPassword(String password)
        {
            return this.users.Exists(x => x.Password == password);
        }
        private bool CheckEmail(String email)
        {
            return this.users.Exists(x => x.Email == email);
        }
        public List<User> GetUsersFromSameBuilding(String building)
        {
            List<User> temp = new List<User>();
            temp = this.users.FindAll(x => x.Building == building);
            return temp;
        }
        public void AddTask(String building, String day, int i, Task task)
        {
            DayOrWeek d = this.days.Find(x => x.Name == day);
            User u = this.GetUsersFromSameBuilding(building)[i];
            if (this.CheckUser(u, building) && u.DeterminePassword != "@admin")
            {
                d.Add(u, task);
            }
            else
            {
                for (i = 0; i < this.GetUsersFromSameBuilding(building).Count; i++)
                {
                    u = this.GetUsersFromSameBuilding(building)[i];
                    if (this.CheckUser(u, building) && u.DeterminePassword != "@admin")
                    {
                        d.Add(u, task);
                        break;
                    }
                }
            }
        }
        private bool CheckUser(User u, String building)
        {
            int number = 0;
            List<User> temp = new List<User>();
            temp = this.GetUsersFromSameBuilding(building);
            foreach (DayOrWeek d in this.days)
            {
                if (d.Students.Contains(u))
                {
                    number += d.GetNumberOfTimes(u);
                }
            }
            double checker = 23 / (temp.Count);
            return number <= Math.Ceiling(checker);
        }
        public void ClearAllDays(String building)
        {
            foreach(DayOrWeek d in this.days)
            {
                d.RemoveAllAtTheBuilding(building);
            }
        }       
        public User GetUser(int userNumber, String password)
        {
            if (this.users.Exists(x => x.Password == password && x.UserNumber == userNumber))
            {
                User u = this.users.Find(x => x.Password == password && x.UserNumber == userNumber);
                return u;
            }
            else
            {
                throw new Exception("There is no such account!");
            }
        }
        public User GetUser(int userNumber)
        {
            User u = this.users.Find(x => x.UserNumber == userNumber);
            return u;
        }
        public List<DayOrWeek> GetAllDays(User u)
        {
            if (u == null)
            {
                return this.days;
            }
            else
            {
                return this.days.FindAll(x => x.Students.Contains(u));
            }
        }
        public List<User> GetAllUsers()
        {
            return this.users;
        }
        public List<String> GetDays()
        {
            List<String> temp = new List<string>(Enum.GetNames(typeof(DaysOfTheWeek)));
            return temp;
        }
        public List<Task> GetAllTasks()
        {
            return this.tasks;
        }
        public List<Event> GetEvents()
        {
            return this.events;
        }
    }
}

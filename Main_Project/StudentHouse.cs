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
        private List<SharedItems> sharedItem;
        private List<Task> tasks;
        private List<Complaint> complaints;
        private List<Event> events;
        List<Building> buildings;
        public SharedItemsManager manager;
  
        private Random rand;
        public StudentHouse()
        {
            this.manager = new SharedItemsManager();
            this.users = new List<User>() { new User(2312, "Peter", "Aleksandrov", "Skachkov", "viktor.skachkov01@gmail.com", "B1", 1, "pas", "@student", false, false),
                                            new User(4343, "Cisco", "Aleksandrov", "Skachkov", "viktor.skachkov01@gmail.com", "B1", 3,  "pas", "@student", false, false),
                                            new User(9797, "Sergo", "Aleksandrov", "Skachkov", "viktor.skachkov01@gmail.com", "B1", 2, "pas", "@student", false, false),
                                            new User(4545, "Viktor", "Aleksandrov", "Skachkov", "viktor.skachkov01@gmail.com", "B1", 1, "pas", "@student", false, false),
                                            new User(1234, "Johnny", "Brown", "Kerrigan", "j.kerriganY@gmail.com", "B2", 1,  "pas", "@student", true, false),
                                            new User(1, "Pavel", "Ivanov", "Vasilov", "pav.vasilov999@gmail.com", "admin", 1, "admin", "@admin", false, false)};           
            this.days = new List<DayOrWeek>() { new DayOrWeek("Monday"), new DayOrWeek("Tuesday"), new DayOrWeek("Wednesday"), new DayOrWeek("Thursday"), new DayOrWeek("Friday"), new DayOrWeek("Saturday"), new DayOrWeek("Sunday"), new DayOrWeek("This week")};
            this.tasks = new List<Task>() { new Task("do the garbage disposal", "daily"), new Task("swipe the whole property", "daily"), new Task("clean the dishes", "daily"), new Task("clean the bathroom", "weekly"), new Task("clean the whole property", "weekly") };
            this.buildings = new List<Building>()
            {
                new Building("B1", 4),
                new Building("B2", 5),
                new Building("B3", 5),
                new Building("B4", 5)
            };
            this.events = new List<Event>();
            this.complaints = new List<Complaint>();
            this.rand = new Random();
        }
        public SharedItems shared
        {
            get
            {
                return this.shared;
            }
        }
        public void AddUser(int userNumber, String firstName, String surname, String lastName, String email, String building, int room, String password, String determinePassword, bool pending, bool banned)
        {
                if (!this.CheckName(firstName, surname, lastName))
                {
                    if (!this.CheckEmail(email))
                    {
                        if (!this.CheckPassword(password))
                        {
                            this.users.Add(new User(userNumber, firstName, surname, lastName, email, building, room, password, determinePassword, pending, banned));
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

        public void AddEvent(User organizer, String day, String time, String name, String building)
        {
            this.events.Add(new Event(organizer, day, time, name, building));
        }
        public void RemoveEvent(Event e)
        {
            this.events.Remove(e);
        }
        public List<Event> GetEvents(String building)
        {
            List<Event> temp = new List<Event>();
            temp = this.events.FindAll(x => x.Building == building);
            return temp;
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
        public bool CheckRoom(String address, int room)
        {
            List<User> temp = this.GetUsersFromSameBuilding(address);
            return temp.Exists(x => x.Building == address);
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
        public void AddBuilding(string name, int capacity)
        {
            if(!this.buildings.Exists(x => x.Name == name))
            {
                this.buildings.Add(new Building(name, capacity));
                throw new Exception("Building successfully added!");
            }
            else
            {
                throw new Exception("Building with this name already exists!");
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
        public void ClearAllDays()
        {
            foreach(DayOrWeek d in this.days)
            {
                d.RemoveAll();
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
        public List<Building> GetAllBuildings()
        {
            return this.buildings;
        }
        public Building GetBuilding(int index)
        {
            return buildings.ElementAt(index);
        }
    }
}

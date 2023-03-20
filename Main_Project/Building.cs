using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_House
{
    public class Building
    {
        // private char additionalInitials;
        private string name;
        private int capacity;

        List<int> rooms;
        public Building(String name, /*char additionalInitials, */int capacity)
        {
            this.name = name ;
            this.rooms = new List<int>();
            for (int number = 1; number <= capacity; number++)
            {
                this.rooms.Add(number);
            }
        }
        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }


        public string Name
        {
            get { return this.name; }
            private set { this.name = value;/*{additionalInitials}*/ }
        }


        public List<int> GetRooms()
        {
            return this.rooms;
        }


        public override string ToString()
        {
            return $" {this.name} || {this.Capacity}";

        }
    }
}
